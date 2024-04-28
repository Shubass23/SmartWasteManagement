# Smart Waste Management System: An IoT-Based Approach for Automated Waste Classification and Bin Monitoring

The scope of this project focused on the development and implementation of an AI-based 
waste classification system using the YOLOv5 model, as well as the integration of IoT 
sensors for bin monitoring. 

## Waste Classification using YoloV5
The AI system involved training the YOLOv5 model to 
accurately identify and categorize six types of waste, such as paper, cardboard, glass, 
metal, plastic, and trash. This system aimed to facilitate accurate and automated waste 
sorting, thereby enhancing recycling rates and reducing the incidence of improper waste 
disposal.

## Bin Monitoring using IoT Sensors (MQ-4, MQ-135, Ultrasonic)
In addition to the AI-based classification, IoT sensors were integrated into waste 
bins. These sensors collected real-time data on several parameters, including the level of 
fullness of the bins and the presence of methane and ammonia gases. This data was then 
transmitted through serial communication via USB to a desktop application.
* MQ-4 - Methane Gas
* MQ-135 - Ammonia Gas
* Ultrasonic Sensor - Bin Fullness Level

## Desktop Application (C#)
The deployment involves integrating the trained model into the Windows Forms 
application, allowing users to interact with the application's graphical user interface (GUI) 
to perform waste classification tasks. The Windows Forms application provides a user-friendly 
interface that enables users, such as waste management personnel, to easily access 
and utilize the waste classification system.

### Classification UI
!(classification_image_ui_1)[images\calibration_ui.png]

### Authenthication UI

### Sensor Calibration UI

### Sensor Reading UI

### User Management UI

### Reporting UI

### 



## Mobile Application (Flutter)
A mobile application was developed specifically for waste 
management personnel. This application enabled them to monitor bin readings from 
remote locations in real time and receive notifications when the bins reached 
predetermined thresholds for fullness, methane, and ammonia gas levels.

### Sensors Live Readings UI

### Waste Report UI

## Database (MongoDB)
This integration involved the creation of three distinct collections within the 
database. The first collection is "inspection_result," which serves as a repository for storing the 
outcomes of the waste classification model's predictions. The second collection is "sensors_calibration," where the threshold values for the various 
sensors used in the system are stored. The third collection, "user_credential," is responsible for storing the login details and 
credentials of the waste management personnel. The fourth collection, "sensors_reading," is responsible for storing the sensors readings 
every five seconds such as ultrasonic sensor, MQ4 sensor and MQ135 sensor.

# References
Cheema, S. M., Hannan, A., & Pires, I. M. (2022). Smart Waste Management and 
Classification Systems Using Cutting Edge Approach. Sustainability, 14(16), 
10226. https://doi.org/10.3390/su141610226

F. O. Ogunwolu, H. I. Mbom, A. Raji and A. Omiyale. (2020). Design and implementation 
of an IoT based smart waste bin for fill level and biodegradability 
monitoring. Journal of Engineering Research, 25(3).

White, G., Cabrera, C., Palade, A., Li, F., & Clarke, S. (2020). WasteNet: Waste 
classification at the edge for smart bins. In arXiv [cs.CV]. 
http://arxiv.org/abs/2006.05873

Abdu, H., & Noor, M. H. M. (2022). A Survey on Waste Detection and Classification 
Using Deep Learning. IEEE Access, 10, 128151-128165.

Patro, N., Bramhankar, D., Sarode, S., & P , S. (2021). 19th National Conference on 
Science, Engineering and Technology. In Implementation of IoT based Smart 
Waste Management system in Node Red. Chennai, India; Vellore Institute 
of Technology.

Orimogunje, A. M., Fred-Ahmadu, O. V., Adewale, A. A., Olaitan, A., Misra, S., Agrawal, 
A., & Ahuja, R. (2022). Design and development of smart waste bin for effective 
waste collection and management. In Futuristic Trends in Networks and 
Computing Technologies (pp. 363–372). Springer Nature Singapore.

Adedeji, O., & Wang, Z. (2019). Intelligent waste classification system using deep 
learning convolutional neural network. Procedia Manufacturing, 35, 607–612. 
https://doi.org/10.1016/j.promfg.2019.05.086

Yuan, Z., & Liu, J. (2022). A hybrid deep learning model for trash classification based on 
deep trasnsfer learning. Journal of Electrical and Computer Engineering, 2022, 
1–9. https://doi.org/10.1155/2022/7608794

Wu, Z., Zhang, D., Shao, Y., Zhang, X., Zhang, X., Feng, Y., & Cui, P. (2021). Using 
YOLOv5 for Garbage Classification. 2021 4th International Conference on 
Pattern Recognition and Artificial Intelligence (PRAI), 35–38.
61

Afolalu, S. A., Noiki, A. A., Ikumapayi, O. M., Ogundipe, A. T., & Oloyede, O. R. (2021). 
Development of smart waste bin for solid waste management. International 
Journal of Sustainable Development and Planning, 16(8), 1449–1454. 
https://doi.org/10.18280/ijsdp.160805

