import 'package:flutter/cupertino.dart';

class InspectionResultModel {
  String? imageName;
  String result;
  DateTime? createdDate;

  InspectionResultModel({this.createdDate, this.imageName, required this.result});
}

// class UserCredentialModel {
//   String? userID;
//   String? firstName;
//   String? lastName;
//   String? password;
//   DateTime? lastLogin;
//   DateTime? lastLogout;
//   DateTime? creationDate;
//
//   UserCredentialModel({this.userID, this.firstName, this.lastName, this.password, this.lastLogin, this.lastLogout, this.creationDate});
// }

class Sensor {

  String name;
  ValueNotifier<double> currValue;
  double maxValue;
  String unit;

  Sensor({required this.name, required this.currValue, required this.maxValue, required this.unit});
}