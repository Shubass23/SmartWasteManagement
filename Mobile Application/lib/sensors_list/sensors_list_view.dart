import 'package:smartbinapp/fitness_app_theme.dart';
import 'package:smartbinapp/sensors_list/sensors_list_data.dart';
import 'package:smartbinapp/main.dart';
import 'package:flutter/material.dart';
import 'package:step_progress_indicator/step_progress_indicator.dart';

class SensorsListView extends StatefulWidget {
  SensorsListView(
      {Key? key, this.mainScreenAnimationController, this.mainScreenAnimation, this.sensorsListData})
      : super(key: key);

  AnimationController? mainScreenAnimationController;
  Animation<double>? mainScreenAnimation;
  List<SensorsListData>? sensorsListData;

  @override
  _SensorsListViewState createState() => _SensorsListViewState();
}

class _SensorsListViewState extends State<SensorsListView>
    with TickerProviderStateMixin {
  AnimationController? animationController;

  @override
  void initState() {
    animationController = AnimationController(
        duration: const Duration(milliseconds: 2000), vsync: this);
    super.initState();
  }

  @override
  void dispose() {
    if(animationController != null)animationController?.dispose();
    super.dispose();
  }

  @override
  Widget build(BuildContext context) {
    return AnimatedBuilder(
      animation: widget.mainScreenAnimationController!,
      builder: (BuildContext context, Widget? child) {
        return FadeTransition(
          opacity: widget.mainScreenAnimation!,
          child: Transform(
            transform: Matrix4.translationValues(
                0.0, 30 * (1.0 - widget.mainScreenAnimation!.value), 0.0),
            child: Container(
              height: 216,
              width: double.infinity,
              child: ListView.builder(
                padding: const EdgeInsets.only(
                    top: 10.0, bottom: 0, right: 16, left: 16),
                itemCount: widget.sensorsListData!.length,
                scrollDirection: Axis.horizontal,
                itemBuilder: (BuildContext context, int index) {
                  final int count =
                  widget.sensorsListData!.length > 10 ? 10 : widget.sensorsListData!.length;
                  final Animation<double> animation =
                      Tween<double>(begin: 0.0, end: 1.0).animate(
                          CurvedAnimation(
                              parent: animationController!,
                              curve: Interval((1 / count) * index, 1.0,
                                  curve: Curves.fastOutSlowIn)));
                  animationController?.forward();

                  return SensorsView(
                    sensorsListData: widget.sensorsListData![index],
                    animation: animation,
                    animationController: animationController!,
                  );
                },
              ),
            ),
          ),
        );
      },
    );
  }
}

class SensorsView extends StatelessWidget {
  const SensorsView({super.key, required this.sensorsListData, this.animationController, this.animation});

  final SensorsListData sensorsListData;
  final AnimationController? animationController;
  final Animation<double>? animation;

  Color getColor (SensorsListData currSensorData){
    double val = (currSensorData.sensor.currValue.value/currSensorData.sensor.maxValue)*100;
    if(val<50.0){
      return Colors.green.shade200;
    }
    else if(val<85.0){
      return Colors.yellow.shade400;
    }
    else{
      return Colors.red.shade800;
    }
  }

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
            child: SizedBox(
              width: 130,
              child: Stack(
                children: <Widget>[
                  Padding(
                    padding: const EdgeInsets.only(
                        top: 30, left: 8, right: 8, bottom: 16),
                    child: Container(
                      decoration: BoxDecoration(
                        boxShadow: <BoxShadow>[
                          BoxShadow(
                              color: HexColor(sensorsListData.endColor)
                                  .withOpacity(0.6),
                              offset: const Offset(1.1, 4.0),
                              blurRadius: 8.0),
                        ],
                        gradient: LinearGradient(
                          colors: <HexColor>[
                            HexColor(sensorsListData.startColor),
                            HexColor(sensorsListData.endColor),
                          ],
                          begin: Alignment.topLeft,
                          end: Alignment.bottomRight,
                        ),
                        borderRadius: const BorderRadius.only(
                          bottomRight: Radius.circular(8.0),
                          bottomLeft: Radius.circular(8.0),
                          topLeft: Radius.circular(8.0),
                          topRight: Radius.circular(54.0),
                        ),
                      ),
                      child: Padding(
                        padding: const EdgeInsets.only(
                            top: 40, left: 16, right: 16, bottom: 2),
                        child: Column(
                          mainAxisAlignment: MainAxisAlignment.center,
                          crossAxisAlignment: CrossAxisAlignment.start,
                          children: <Widget>[
                            Text(
                              sensorsListData.titleTxt,
                              textAlign: TextAlign.center,
                              style: TextStyle(
                                fontFamily: FitnessAppTheme.fontName,
                                fontWeight: FontWeight.bold,
                                fontSize: 10,
                                letterSpacing: 0.2,
                                color: FitnessAppTheme.white,
                              ),
                            ),
                            SizedBox(height: 10.0),
                            Container(
                              height: 40.0,
                              child: Text(
                                sensorsListData.description,
                                style: TextStyle(
                                  fontFamily: FitnessAppTheme.fontName,
                                  fontWeight: FontWeight.w500,
                                  fontSize: 8,
                                  letterSpacing: 0.2,
                                  color: FitnessAppTheme.white,
                                ),
                              ),
                            ),
                            Row(
                              mainAxisAlignment: MainAxisAlignment.start,
                              crossAxisAlignment: CrossAxisAlignment.end,
                              children: <Widget>[
                                ValueListenableBuilder(
                                  valueListenable: sensorsListData.sensor.currValue,
                                  builder: (BuildContext context, double value, Widget? child){
                                    return Text(
                                      sensorsListData.sensor.currValue.value.toString(),
                                      textAlign: TextAlign.center,
                                      style: TextStyle(
                                        fontFamily: FitnessAppTheme.fontName,
                                        fontWeight: FontWeight.w500,
                                        fontSize: 20,
                                        letterSpacing: 0.2,
                                        color: FitnessAppTheme.white,
                                      ),
                                    );
                                  },
                                ),
                                Padding(
                                  padding: const EdgeInsets.only(
                                      left: 4, bottom: 3),
                                  child: Text(
                                    sensorsListData.sensor.unit,
                                    style: TextStyle(
                                      fontFamily:
                                      FitnessAppTheme.fontName,
                                      fontWeight: FontWeight.w500,
                                      fontSize: 10,
                                      letterSpacing: 0.2,
                                      color: FitnessAppTheme.white,
                                    ),
                                  ),
                                ),
                              ],
                            )
                          ],
                        ),
                      ),
                    ),
                  ),
                  Positioned(
                      top: 0,
                      left: 10,
                      child: Container(
                        height: 70.0,
                        width: 120.0,
                        child: Row(
                          children: [
                            Container(
                              child: SizedBox(
                                width: 70,
                                height: 80,
                                child: Image.asset(sensorsListData.imagePath),
                              ),
                            ),
                            Container(
                              width: 20.0,
                              height: 75.0,
                              child: ValueListenableBuilder(
                                valueListenable: sensorsListData.sensor.currValue,
                                builder: (BuildContext context, double value, Widget? child){
                                  return StepProgressIndicator(
                                    totalSteps: 6,
                                    currentStep: 6 - ((sensorsListData.sensor.currValue.value/sensorsListData.sensor.maxValue*6).round()),
                                    size: 10,
                                    selectedColor: Colors.grey.shade400,
                                    unselectedColor: getColor(sensorsListData),
                                    roundedEdges: Radius.circular(10.0),
                                    direction: Axis.vertical,
                                  );
                                }
                              ),
                            ),
                          ],
                        ),
                      )
                  ),
                ],
              ),
            ),
          ),
        );
      },
    );
  }
}
//
// class SensorsView extends StatefulWidget {
//   SensorsView(
//       {Key? key, required this.sensorsListData, this.animationController, this.animation})
//       : super(key: key);
//
//   SensorsListData? sensorsListData;
//   final AnimationController? animationController;
//   final Animation<double>? animation;
//
//   @override
//   State<SensorsView> createState() => _SensorsViewState();
// }
//
// class _SensorsViewState extends State<SensorsView> {
//
//   @override
//   void initState() {
//     super.initState();
//   }
//
//   @override
//   void dispose() {
//     // if(widget.animationController != null) widget.animationController?.dispose();
//     super.dispose();
//   }
//
//   Color getColor (SensorsListData currSensorData){
//     double val = (currSensorData.sensor.currValue.value/currSensorData.sensor.maxValue)*100;
//     if(val<50.0){
//       return Colors.green.shade200;
//     }
//     else if(val<85.0){
//       return Colors.yellow.shade400;
//     }
//     else{
//       return Colors.red.shade800;
//     }
//   }
//
//   @override
//   Widget build(BuildContext context) {
//     return AnimatedBuilder(
//       animation: widget.animationController!,
//       builder: (BuildContext context, Widget? child) {
//         return FadeTransition(
//           opacity: widget.animation!,
//           child: Transform(
//             transform: Matrix4.translationValues(
//                 100 * (1.0 - widget.animation!.value), 0.0, 0.0),
//             child: SizedBox(
//               width: 130,
//               child: Stack(
//                 children: <Widget>[
//                   Padding(
//                     padding: const EdgeInsets.only(
//                         top: 30, left: 8, right: 8, bottom: 16),
//                     child: Container(
//                       decoration: BoxDecoration(
//                         boxShadow: <BoxShadow>[
//                           BoxShadow(
//                               color: HexColor(widget.sensorsListData!.endColor)
//                                   .withOpacity(0.6),
//                               offset: const Offset(1.1, 4.0),
//                               blurRadius: 8.0),
//                         ],
//                         gradient: LinearGradient(
//                           colors: <HexColor>[
//                             HexColor(widget.sensorsListData!.startColor),
//                             HexColor(widget.sensorsListData!.endColor),
//                           ],
//                           begin: Alignment.topLeft,
//                           end: Alignment.bottomRight,
//                         ),
//                         borderRadius: const BorderRadius.only(
//                           bottomRight: Radius.circular(8.0),
//                           bottomLeft: Radius.circular(8.0),
//                           topLeft: Radius.circular(8.0),
//                           topRight: Radius.circular(54.0),
//                         ),
//                       ),
//                       child: Padding(
//                         padding: const EdgeInsets.only(
//                             top: 40, left: 16, right: 16, bottom: 2),
//                         child: Column(
//                           mainAxisAlignment: MainAxisAlignment.center,
//                           crossAxisAlignment: CrossAxisAlignment.start,
//                           children: <Widget>[
//                             Text(
//                               widget.sensorsListData!.titleTxt,
//                               textAlign: TextAlign.center,
//                               style: TextStyle(
//                                 fontFamily: FitnessAppTheme.fontName,
//                                 fontWeight: FontWeight.bold,
//                                 fontSize: 10,
//                                 letterSpacing: 0.2,
//                                 color: FitnessAppTheme.white,
//                               ),
//                             ),
//                             SizedBox(height: 10.0),
//                             Container(
//                               height: 40.0,
//                               child: Text(
//                                 widget.sensorsListData!.description,
//                                 style: TextStyle(
//                                   fontFamily: FitnessAppTheme.fontName,
//                                   fontWeight: FontWeight.w500,
//                                   fontSize: 8,
//                                   letterSpacing: 0.2,
//                                   color: FitnessAppTheme.white,
//                                 ),
//                               ),
//                             ),
//                             Row(
//                               mainAxisAlignment: MainAxisAlignment.start,
//                               crossAxisAlignment: CrossAxisAlignment.end,
//                               children: <Widget>[
//                                 ValueListenableBuilder(
//                                   valueListenable: widget.sensorsListData!.sensor.currValue,
//                                   builder: (BuildContext context, double value, Widget? child){
//                                     return Text(
//                                       widget.sensorsListData!.sensor.currValue.value.toString(),
//                                       textAlign: TextAlign.center,
//                                       style: TextStyle(
//                                         fontFamily: FitnessAppTheme.fontName,
//                                         fontWeight: FontWeight.w500,
//                                         fontSize: 24,
//                                         letterSpacing: 0.2,
//                                         color: FitnessAppTheme.white,
//                                       ),
//                                     );
//                                   },
//                                 ),
//                                 Padding(
//                                   padding: const EdgeInsets.only(
//                                       left: 4, bottom: 3),
//                                   child: Text(
//                                     widget.sensorsListData!.sensor.unit,
//                                     style: TextStyle(
//                                       fontFamily:
//                                       FitnessAppTheme.fontName,
//                                       fontWeight: FontWeight.w500,
//                                       fontSize: 10,
//                                       letterSpacing: 0.2,
//                                       color: FitnessAppTheme.white,
//                                     ),
//                                   ),
//                                 ),
//                               ],
//                             )
//                           ],
//                         ),
//                       ),
//                     ),
//                   ),
//                   Positioned(
//                       top: 0,
//                       left: 10,
//                       child: Container(
//                         height: 70.0,
//                         width: 120.0,
//                         child: Row(
//                           children: [
//                             Container(
//                               child: SizedBox(
//                                 width: 70,
//                                 height: 80,
//                                 child: Image.asset(widget.sensorsListData!.imagePath),
//                               ),
//                             ),
//                             Container(
//                               width: 20.0,
//                               height: 75.0,
//                               child: StepProgressIndicator(
//                                 totalSteps: 6,
//                                 currentStep: 6 - ((widget.sensorsListData!.sensor.currValue.value/widget.sensorsListData!.sensor.maxValue*6).round()),
//                                 size: 10,
//                                 selectedColor: Colors.grey.shade400,
//                                 unselectedColor: getColor(widget.sensorsListData!),
//                                 roundedEdges: Radius.circular(10.0),
//                                 direction: Axis.vertical,
//                               ),
//                             ),
//                           ],
//                         ),
//                       )
//                   ),
//                 ],
//               ),
//             ),
//           ),
//         );
//       },
//     );
//   }
// }



