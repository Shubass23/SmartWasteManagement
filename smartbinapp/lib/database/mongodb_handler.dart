import 'package:mongo_dart/mongo_dart.dart';

class MongoDBHandler {
  final username = 'Shubass';
  final password = 'test1234';
  final String databaseName = 'smart_waste_management';
  final connectionString = 'mongodb://192.168.1.8:27017/';
  Db? db;

  Future<void> getDatabaseConnection() async {
    db = await Db.create("mongodb+srv://Shubass:test1234@cluster0.guugpkj.mongodb.net/smart_waste_management?retryWrites=true&w=majority");
    await db?.open();
  }
}

