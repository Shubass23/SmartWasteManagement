import 'package:smartbinapp/models/models.dart';
//paper, cardboard, glass, metal, plastic and trash.
class WastesListData {

  String wasteType;
  int totalAmount;
  String startColor;
  String endColor;
  String description;
  DateTime startDate;
  DateTime endDate;
  String imagePath;

  WastesListData({
    this.wasteType = '',
    this.totalAmount = 0,
    this.startColor = '',
    this.endColor = '',
    this.description = '',
    this.imagePath = '',
    DateTime? startDate,
    DateTime? endDate
  }) : startDate = startDate ?? DateTime.now(),
        endDate = endDate ?? DateTime.now().add(Duration(days: 5));

  static List<WastesListData> tabIconsList = <WastesListData>[
    WastesListData(
      wasteType: 'Paper',
      totalAmount: 0,
      description: 'Discarded paper products, such as newspapers and office documents, suitable for recycling.',
      startColor: '#CD7F32',
      endColor: '#DAA06D',
      imagePath: 'assets/paper.png',
    ),
    WastesListData(
      wasteType: 'Cardboard',
      totalAmount: 0,
      description: 'Used packaging material made of thick paperboard, commonly recycled to reduce environmental impact.',
      startColor: '#d6ae7b',
      endColor: '#eacda3',
      imagePath: 'assets/cardboard.png',
    ),
    WastesListData(
      wasteType: 'Glass',
      totalAmount: 0,
      description: 'Discarded glass containers and products, recyclable and often reprocessed into new glass items.',
      startColor: '#61045f',
      endColor: '#aa076b',
      imagePath: 'assets/glass.png',
    ),
    WastesListData(
      wasteType: 'Metal',
      totalAmount: 0,
      description: 'Scrap metal items, including aluminum and steel, collected for recycling to conserve resources.',
      startColor: '#2c3e50',
      endColor: '#bdc3c7',
      imagePath: 'assets/metal.png',
    ),
    WastesListData(
      wasteType: 'Plastic',
      totalAmount: 0,
      description: 'Non-biodegradable materials derived from polymers, like bottles and packaging, posing environmental challenges.',
      startColor: '#02aab0',
      endColor: '#00cda',
      imagePath: 'assets/plastic.png',
    ),
    WastesListData(
      wasteType: 'Trash',
      totalAmount: 0,
      description: 'General household waste, comprising non-recyclable and non-organic items, typically destined for landfills or incineration.',
      startColor: '#56ab2f',
      endColor: '#a8e063',
      imagePath: 'assets/trash.png',
    )
  ];
}
