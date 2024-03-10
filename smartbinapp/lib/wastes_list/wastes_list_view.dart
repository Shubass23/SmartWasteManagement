import 'package:fl_chart/fl_chart.dart';
import 'package:flutter/material.dart';
import 'package:google_fonts/google_fonts.dart';
import 'package:intl/intl.dart';
import 'package:smartbinapp/wastes_list/wastes_list_data.dart';
import '../database/Query/inspection_query.dart';
import '../database/mongodb_handler.dart';
import '../fitness_app_theme.dart';
import '../main.dart';
import '../models/models.dart';
import '../ui_view/calendar_popup_view.dart';

class WasteListView extends StatefulWidget {
  WasteListView(
      {Key? key,
      this.animationController,
      this.animation,
      required this.mongodb})
      : super(key: key);

  AnimationController? animationController;
  Animation<double>? animation;
  MongoDBHandler mongodb;

  @override
  State<WasteListView> createState() => _WasteListViewState();
}

class _WasteListViewState extends State<WasteListView>
    with TickerProviderStateMixin {
  AnimationController? animationController;
  InspectionResultQuery? inspectionResultQuery;
  List<WastesListData> wastesListData = WastesListData.tabIconsList;
  Map<String, List<InspectionResultModel>> wasteInspectionResults = {
    'Paper': [],
    'Cardboard': [],
    'Glass': [],
    'Metal': [],
    'Plastic': [],
    'Trash': []
  };
  DateTime startDate = DateTime.now().subtract(const Duration(days: 60));
  DateTime endDate = DateTime.now();

  @override
  void initState() {
    animationController = AnimationController(
        duration: const Duration(milliseconds: 2000), vsync: this);
    getDatabase();
    super.initState();
  }

  @override
  void dispose() {
    if (animationController != null) animationController?.dispose();
    super.dispose();
  }

  void getDatabase() async {
    await widget.mongodb.getDatabaseConnection();
    inspectionResultQuery = InspectionResultQuery(widget.mongodb);
    getInspectionData();
  }

  void getInspectionData() async {
    try {
      List<InspectionResultModel>? results =
          await inspectionResultQuery?.getResultsByDates(startDate, endDate);
      sortData(results!);
    } catch (e) {
      return;
    }
  }

  void sortData(List<InspectionResultModel> results) {
    setState(() {
      for (var element in wastesListData) {
        element.startDate = startDate;
        element.endDate = endDate;
      }
      if (results.isEmpty) {
        for (var element in wasteInspectionResults.keys) {
          wasteInspectionResults[element] = [];
        }
        for (var element in wastesListData) {
          element.totalAmount = 0;
        }
      } else {
        for (InspectionResultModel result in results!) {
          String wasteType = result.result[0].toUpperCase() +
              result.result.substring(1).toLowerCase();
          wasteInspectionResults[wasteType]?.add(result);
          for (WastesListData waste in wastesListData) {
            if (waste.wasteType == wasteType) {
              waste.totalAmount += 1;
            }
          }
        }
      }
    });
    // for (var element in wastesListData) {element.startDate = startDate; element.endDate = endDate;}
    // for(InspectionResultModel result in results){
    //   String wasteType = result.result[0].toUpperCase() + result.result.substring(1).toLowerCase();
    //   print(wasteType);
    //   wasteInspectionResults[wasteType]?.add(result);
    //   for (WastesListData waste in wastesListData){
    //     if(waste.wasteType == wasteType){
    //       waste.totalAmount += 1;
    //     }
    //   }
    // }
    // print(wastesListData[0].totalAmount);
    // print(wastesListData[1].totalAmount);
    // print(wastesListData[2].totalAmount);
    // print(wastesListData[3].totalAmount);
    // print(wastesListData[4].totalAmount);
    // print(wastesListData[5].totalAmount);
    // print(wasteInspectionResults);
  }

  void showDemoDialog({BuildContext? context}) {
    showDialog<dynamic>(
      context: context!,
      builder: (BuildContext context) => CalendarPopupView(
        barrierDismissible: true,
        // minimumDate: DateTime.now(),
        // maximumDate: DateTime(DateTime.now().year, DateTime.now().month, DateTime.now().day + 10),
        initialEndDate: endDate,
        initialStartDate: startDate,
        onApplyClick: (DateTime startData, DateTime endData) {
          setState(() {
            startDate = startData;
            endDate = endData;
          });
        },
        onCancelClick: () {},
      ),
    );
  }

  Widget getCalendarView() {
    return AnimatedBuilder(
      animation: widget.animationController!,
      builder: (BuildContext context, Widget? child) {
        return FadeTransition(
          opacity: widget.animation!,
          child: Transform(
              transform: Matrix4.translationValues(
                  0.0, 30 * (1.0 - widget.animation!.value), 0.0),
              child: Padding(
                padding: const EdgeInsets.only(left: 23, bottom: 0, top: 16),
                child: Row(
                  children: <Widget>[
                    Container(
                      padding: EdgeInsets.only(left: 5, right: 20),
                      decoration: BoxDecoration(
                        color: FitnessAppTheme.white,
                        borderRadius: BorderRadius.only(
                            topLeft: Radius.circular(8.0),
                            bottomLeft: Radius.circular(8.0),
                            bottomRight: Radius.circular(8.0),
                            topRight: Radius.circular(8.0)),
                        boxShadow: <BoxShadow>[
                          BoxShadow(
                              color: FitnessAppTheme.grey.withOpacity(0.2),
                              offset: Offset(1.1, 1.1),
                              blurRadius: 10.0),
                        ],
                      ),
                      child: Row(
                        children: <Widget>[
                          Material(
                            child: InkWell(
                              focusColor: Colors.white,
                              highlightColor: Colors.white,
                              hoverColor: Colors.white,
                              splashColor: Colors.white.withOpacity(0.2),
                              borderRadius: const BorderRadius.all(
                                Radius.circular(4.0),
                              ),
                              onTap: () {
                                FocusScope.of(context)
                                    .requestFocus(FocusNode());
                                // setState(() {
                                //   isDatePopupOpen = true;
                                // });
                                showDemoDialog(context: context);
                              },
                              child: Padding(
                                padding: const EdgeInsets.only(
                                    left: 10, right: 10, top: 10, bottom: 10),
                                child: Column(
                                  mainAxisAlignment: MainAxisAlignment.center,
                                  crossAxisAlignment: CrossAxisAlignment.start,
                                  children: <Widget>[
                                    Text(
                                      'Choose date',
                                      style: TextStyle(
                                          fontWeight: FontWeight.w300,
                                          fontSize: 16,
                                          color: Colors.black),
                                    ),
                                    const SizedBox(
                                      height: 8,
                                    ),
                                    Text(
                                      '${DateFormat("dd, MMM, yyyy").format(startDate!)} - ${DateFormat("dd, MMM, yyyy").format(endDate!)}',
                                      style: TextStyle(
                                        fontWeight: FontWeight.w100,
                                        fontSize: 16,
                                      ),
                                    ),
                                  ],
                                ),
                              ),
                            ),
                          ),
                        ],
                      ),
                    ),
                    Padding(
                      padding: const EdgeInsets.only(left: 10, right: 10),
                      child: Container(
                        width: 2,
                        height: 45,
                        color: Colors.grey[400],
                      ),
                    ),
                    Container(
                      child: TextButton(
                        onPressed: () {
                          getInspectionData();
                        },
                        child: Text('UPDATE'),
                        style: ButtonStyle(
                          padding:
                              MaterialStateProperty.all<EdgeInsetsGeometry>(
                                  EdgeInsets.symmetric(
                                      vertical: 15, horizontal: 20)),
                          foregroundColor:
                              MaterialStateProperty.all<Color>(Colors.white),
                          backgroundColor: MaterialStateProperty.all<Color>(
                              Colors.green.shade400),
                        ),
                      ),
                    ),
                  ],
                ),
              )),
        );
      },
    );
  }

  @override
  Widget build(BuildContext context) {
    return AnimatedBuilder(
      animation: widget.animationController!,
      builder: (BuildContext context, Widget? child) {
        return FadeTransition(
          opacity: widget.animation!,
          child: Transform(
              transform: new Matrix4.translationValues(
                  0.0, 30 * (1.0 - widget.animation!.value), 0.0),
              child: Column(
                children: [
                  getCalendarView(),
                  Container(
                    padding: const EdgeInsets.only(
                        left: 24, right: 24, top: 24, bottom: 15.0),
                    child: Column(
                      children: [
                        WasteView(
                          wasteInspectionResults:
                              wasteInspectionResults['Paper']!,
                          wastesListData: wastesListData[0],
                          animationController: widget.animationController,
                          animation: widget.animation,
                        ),
                        WasteView(
                          wasteInspectionResults:
                              wasteInspectionResults['Cardboard']!,
                          wastesListData: wastesListData[1],
                          animationController: widget.animationController,
                          animation: widget.animation,
                        ),
                        WasteView(
                          wasteInspectionResults:
                              wasteInspectionResults['Glass']!,
                          wastesListData: wastesListData[2],
                          animationController: widget.animationController,
                          animation: widget.animation,
                        ),
                        WasteView(
                          wasteInspectionResults:
                              wasteInspectionResults['Metal']!,
                          wastesListData: wastesListData[3],
                          animationController: widget.animationController,
                          animation: widget.animation,
                        ),
                        WasteView(
                          wasteInspectionResults:
                              wasteInspectionResults['Plastic']!,
                          wastesListData: wastesListData[4],
                          animationController: widget.animationController,
                          animation: widget.animation,
                        ),
                        WasteView(
                          wasteInspectionResults:
                              wasteInspectionResults['Trash']!,
                          wastesListData: wastesListData[5],
                          animationController: widget.animationController,
                          animation: widget.animation,
                        )
                      ],
                    ),
                  ),
                ],
              )),
        );
      },
    );
  }

  Future<void> _showMyDialog() async {
    return showDialog<void>(
      context: context,
      barrierDismissible: false, // user must tap button!
      builder: (BuildContext context) {
        return AlertDialog(
          title: const Text('AlertDialog Title'),
          content: SingleChildScrollView(
            child: ListBody(
              children: <Widget>[
                Text('sds'),
              ],
            ),
          ),
          actions: <Widget>[
            TextButton(
              child: const Text('OK'),
              onPressed: () {
                Navigator.of(context).pop();
              },
            ),
          ],
        );
      },
    );
  }
}

class WasteView extends StatelessWidget {
  const WasteView(
      {super.key,
      this.animationController,
      this.animation,
      this.wastesListData,
      required this.wasteInspectionResults});

  final WastesListData? wastesListData;
  final AnimationController? animationController;
  final Animation<double>? animation;
  final List<InspectionResultModel> wasteInspectionResults;

  @override
  Widget build(BuildContext context) {
    return AnimatedBuilder(
        animation: animationController!,
        builder: (BuildContext context, Widget? child) {
          return FadeTransition(
            opacity: animation!,
            child: Transform(
              transform: Matrix4.translationValues(
                  100 * (1.0 - animation!.value), 0.0, 0.0),
              child: Padding(
                padding: const EdgeInsets.only(bottom: 20.0),
                child: Column(
                  children: [
                    Container(
                        padding: EdgeInsets.symmetric(vertical: 5.0),
                        decoration: BoxDecoration(
                          boxShadow: <BoxShadow>[
                            BoxShadow(
                                color: HexColor(wastesListData!.endColor)
                                    .withOpacity(0.6),
                                offset: const Offset(1.1, 4.0),
                                blurRadius: 8.0),
                          ],
                          gradient: LinearGradient(
                            colors: <HexColor>[
                              HexColor(wastesListData!.startColor),
                              HexColor(wastesListData!.endColor),
                            ],
                            begin: Alignment.topLeft,
                            end: Alignment.bottomRight,
                          ),
                          borderRadius: const BorderRadius.only(
                            topLeft: Radius.circular(8.0),
                            topRight: Radius.circular(8.0),
                          ),
                        ),
                        child: Row(
                          children: [
                            Container(
                              padding: EdgeInsets.all(10.0),
                              width: 70,
                              height: 70,
                              child: Image.asset(wastesListData!.imagePath),
                            ),
                            Expanded(
                              child: Column(
                                crossAxisAlignment: CrossAxisAlignment.start,
                                children: [
                                  Container(
                                    child: Text(
                                      wastesListData!.totalAmount.toString() +
                                          ' ' +
                                          wastesListData!.wasteType,
                                      style: GoogleFonts.acme(
                                          fontSize: 30.0,
                                          color: Colors.white,
                                          fontWeight: FontWeight.bold),
                                    ),
                                  ),
                                  Container(
                                    padding: EdgeInsets.only(
                                        bottom: 5.0, right: 10.0),
                                    child: Text(
                                      wastesListData!.description.toString(),
                                      style: GoogleFonts.acme(
                                        fontSize: 10.0,
                                        color: Colors.white,
                                      ),
                                    ),
                                  )
                                ],
                              ),
                            )
                          ],
                        )),
                    Container(
                      decoration: BoxDecoration(
                        color: Colors.white,
                        borderRadius: const BorderRadius.only(
                          bottomRight: Radius.circular(8.0),
                          bottomLeft: Radius.circular(8.0),
                        ),
                      ),
                      padding: EdgeInsets.fromLTRB(0.0, 20.0, 20.0, 30.0),
                      height: 250.0,
                      child: LineChart(LineChartData(
                          gridData: FlGridData(
                            show: false,
                          ),
                          titlesData: FlTitlesData(
                            topTitles: AxisTitles(
                              drawBelowEverything: false,
                            ),
                            rightTitles: AxisTitles(
                              drawBelowEverything: false,
                            ),
                            bottomTitles: AxisTitles(
                              drawBelowEverything: true,
                              sideTitles: SideTitles(
                                showTitles: true,
                                getTitlesWidget: (value, titleMeta) {
                                  // Convert the timestamp (milliseconds since epoch) to a date format
                                  final date = DateTime.fromMillisecondsSinceEpoch(value.toInt());
                                  final formattedDate = '${date.day}/${date.month}';
                                  return Transform.rotate(
                                    angle: -3.14 / 2, // Rotate the text 90 degrees counter-clockwise
                                    child: Padding(
                                      padding: const EdgeInsets.only(right: 20),
                                      child: Text(
                                        formattedDate,
                                      ),
                                    ),
                                  );
                                },
                              ),
                            ),
                          ),
                          borderData: FlBorderData(show: true),
                          minY: 0,
                          lineBarsData: [
                            LineChartBarData(
                                isCurved: true,
                                barWidth: 2,
                                isStrokeCapRound: true,
                                dotData: const FlDotData(show: true),
                                belowBarData: BarAreaData(show: false),
                                spots: convertToFlSpots(wasteInspectionResults))
                          ])),
                    ),
                  ],
                ),
              ),
            ),
          );
        });
  }

  List<FlSpot> convertToFlSpots(List<InspectionResultModel> inspectionResults) {
    Map<DateTime, int> dateToCount = {};
    List<FlSpot> flSpots = [];

    for (int i = 0; i < inspectionResults.length; i++) {
      final inspectionResult = inspectionResults[i];

      if (inspectionResult.createdDate != null) {
        final date = inspectionResult.createdDate!
            .toLocal(); // Ensure the date is in local timezone.
        final dateWithoutTime =
            DateTime(date.year, date.month, date.day); // Remove time part.

        if (dateToCount.containsKey(dateWithoutTime)) {
          dateToCount[dateWithoutTime] = dateToCount[dateWithoutTime]! + 1;
        } else {
          dateToCount[dateWithoutTime] = 1;
        }
      }
    }

    dateToCount.forEach((date, count) {
      final x = date.millisecondsSinceEpoch.toDouble();
      final y = count.toDouble();
      flSpots.add(FlSpot(x, y));
    });
    return flSpots;
  }
}
