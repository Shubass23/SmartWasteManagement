import 'package:smartbinapp/database/mongodb_handler.dart';
import 'package:mongo_dart/mongo_dart.dart';
import 'package:smartbinapp/models/models.dart';

class InspectionResultQuery {

  final collectionName = 'inspection_result';
  DbCollection? dbCollection;
  MongoDBHandler mongoDBHandler;

  InspectionResultQuery (this.mongoDBHandler) {
    getDatabaseCollection();
  }

  void getDatabaseCollection() {
    dbCollection = mongoDBHandler.db?.collection(collectionName);
  }

  Future<List<InspectionResultModel>> getResultsByNumEntries ({int maxEntries = 100}) async {
    List<Map<String, dynamic>>? results = await dbCollection?.find(SelectorBuilder().limit(maxEntries)).toList();
    List<InspectionResultModel> inspectionResults = <InspectionResultModel>[];
    results?.forEach((result) {inspectionResults.add(fromJson(result));});
    return inspectionResults;
  }

  Future<List<InspectionResultModel>> getResultsByDates (DateTime startDate, DateTime endDate) async {
    List<Map<String, dynamic>>? results = await dbCollection?.find(where.gte('CreatedDate', startDate).lte('CreatedDate', endDate)).toList();
    List<InspectionResultModel> inspectionResults = <InspectionResultModel>[];
    results?.forEach((result) {inspectionResults.add(fromJson(result));});
    return inspectionResults;
  }

  InspectionResultModel fromJson (Map<String, dynamic> json) {
    return InspectionResultModel(
        createdDate: json['CreatedDate'],
        imageName: json['ImageName'],
        result: json['Result']
    );
  }

}