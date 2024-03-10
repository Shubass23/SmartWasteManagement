import 'package:flutter/cupertino.dart';
import 'package:smartbinapp/models/models.dart';

class SensorsListData {

  String imagePath;
  String titleTxt;
  String startColor;
  String endColor;
  String description;
  Sensor sensor;

  SensorsListData({
    this.imagePath = '',
    this.titleTxt = '',
    this.startColor = '',
    this.endColor = '',
    this.description = '',
    Sensor? sensor,
  }) : sensor = sensor ?? Sensor(name: '', currValue: ValueNotifier<double>(0.0), maxValue: 0.0, unit: 'NaN');

  static List<SensorsListData> tabIconsList = <SensorsListData>[
    SensorsListData(
      imagePath: 'assets/bin.png',
      titleTxt: 'Fullness Level',
      description: 'Measure the level of bin that has been filled with wastes.',
      startColor: '#FA7D82',
      endColor: '#FFB295',
      sensor: Sensor(name: 'Ultrasonic Sensor', currValue: ValueNotifier<double>(0.0), maxValue: 100.0, unit: 'm\u00b2'),
    ),
    SensorsListData(
      imagePath: 'assets/methane.png',
      titleTxt: 'Methane Level',
      description: 'Measure the amount of methane gas presence inside the bin.',
      startColor: '#FE95B6',
      endColor: '#FF5287',
      sensor: Sensor(name: 'Methane Sensor', currValue: ValueNotifier<double>(0.0), maxValue: 100.0, unit: 'ppm'),
    ),
    SensorsListData(
      imagePath: 'assets/ammonia.png',
      titleTxt: 'Ammonia Level',
      description: 'Measure the amount of ammonia gas presence inside the bin.',
      startColor: '#738AE6',
      endColor: '#5C5EDD',
      sensor: Sensor(name: 'Ammonia Sensor', currValue: ValueNotifier<double>(0.0), maxValue: 100.0, unit: 'ppm'),
    ),
  ];
}
