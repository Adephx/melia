//--- Melia Script -----------------------------------------------------------
// f_flash_60
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Roxona Market' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FFlash60MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners ---------------------------------

		AddSpawner("f_flash_60.Id1", MonsterId.Moya, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_flash_60.Id2", MonsterId.Bavon, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_flash_60.Id3", MonsterId.Moya, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_flash_60.Id4", MonsterId.Bavon, 27, 35, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_flash_60.Id5", MonsterId.Saltisdaughter_Mage, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_flash_60.Id6", MonsterId.Rootcrystal_01, 12, 15, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);
		AddSpawner("f_flash_60.Id7", MonsterId.Saltisdaughter_Mage, 6, 8, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Moya' GenType 3 Spawn Points
		AddSpawnPoint("f_flash_60.Id1", "f_flash_60", Rectangle(465.72095, 6.569856, 9999));

		// 'Bavon' GenType 17 Spawn Points
		AddSpawnPoint("f_flash_60.Id2", "f_flash_60", Rectangle(288.852, -27.00536, 9999));

		// 'Moya' GenType 25 Spawn Points
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-609.1183, -958.9706, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-327.54218, -1097.0597, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-235.91557, -948.02814, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(327.17493, -1034.861, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(475.3275, -1078.7299, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(453.4657, -922.7601, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1265.467, -1083.8539, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1190.8584, -805.8088, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1305.1906, -938.99054, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-614.70825, -822.676, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-391.76505, -950.8339, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-136.11334, -1110.7745, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(312.95474, -916.278, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(182.82013, -772.93304, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(108.34464, -302.30194, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(328.75443, -249.44266, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(353.73993, -27.883736, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(217.68098, -143.01271, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(379.3105, 99.71578, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(218.66953, 440.41296, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(65.04744, 522.34705, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(144.38771, 680.6569, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1193.5948, -307.79907, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1275.3434, -402.85068, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1177.3876, -498.32236, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-669.80383, -85.93994, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-826.4423, 438.09872, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-697.9601, 43.724632, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-728.21436, -253.69662, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1337.7782, -1072.9061, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1362.4016, -979.7389, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1267.8209, -975.2269, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1210.8629, -903.49365, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1156.6761, -835.8667, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1129.3838, -769.1006, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1221.7406, -851.1853, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1184.7181, -933.1261, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1242.09, -1024.3097, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1217.9946, -1042.364, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1198.2972, -1080.5337, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1152.3484, -1100.7472, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1197.8232, -1139.9589, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1233.6969, -1113.1648, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1272.9982, -1138.9908, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1343.7582, -1126.58, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1404.4172, -1154.8484, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1297.5845, -1104.5721, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1362.7312, -1023.7455, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1358.867, -924.9583, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1435.658, -1136.3121, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1382.4844, -1113.6166, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1370.982, -1169.7595, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1403.2218, -981.271, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1334.7946, -941.72595, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1137.0918, -281.8542, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1206.4363, -274.79318, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1105.7881, -322.62363, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1157.7428, -339.9737, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1086.6414, -398.9087, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1115.4868, -435.50946, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1162.9968, -426.26077, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1212.2849, -373.5614, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1186.8506, -393.45853, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1239.5186, -428.849, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1219.4539, -477.17615, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1196.1073, -444.94385, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1220.8445, -528.35443, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1130.9607, -535.926, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-1103.4415, -570.38947, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-683.8315, -912.4748, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-571.0836, -877.25366, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-539.5637, -940.76746, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-473.4929, -914.9974, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-398.78662, -1007.5314, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-291.798, -987.0982, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-317.0644, -962.0245, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-192.50107, -894.8336, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-142.68259, -963.4417, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-208.23355, -1011.2575, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-187.72142, -959.579, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-251.6919, -1100.8715, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-262.77682, -1053.4811, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-316.42487, -1166.3416, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-276.5069, -1158.6246, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-365.0727, -1142.6649, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-397.72742, -1105.5969, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-429.809, -1061.3693, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-350.91895, -1020.2427, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-484.0409, -1029.8953, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-740.54205, -880.1157, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-784.833, -935.7479, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-745.34845, -1032.1332, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-668.777, -1054.7986, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-663.2949, -968.8693, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(248.88585, -1097.0381, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(256.0542, -1037.4812, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(300.891, -1081.5474, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(409.50775, -1101.8826, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(471.28784, -1128.512, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(502.12143, -1051.2736, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(444.39764, -1043.2288, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(439.2033, -984.6461, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(527.5552, -995.59686, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(508.58426, -1113.6603, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(391.09216, -945.1931, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(517.4646, -869.43463, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(452.1935, -845.7484, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(372.32318, -880.41223, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(307.85678, -851.9096, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(342.61807, -805.5284, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(261.29684, -788.21466, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(199.3166, -822.7535, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(282.6418, -817.02203, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(231.89198, -890.9268, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(279.57263, -888.80945, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(256.6227, -968.34705, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(354.59305, -969.9457, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(302.04044, -999.24207, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(351.4835, -929.6004, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(143.70331, -810.8022, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(220.21455, -773.53973, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(122.22501, -756.1809, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(154.18327, -766.2349, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(116.54039, -804.1263, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(110.00563, -723.0659, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(504.35385, -184.99487, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(416.56964, -211.87036, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(526.0202, -215.42809, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(447.99484, -176.23506, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(524.0571, -18.270658, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(405.2735, -80.40485, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(433.3136, 8.375125, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(286.91086, -67.07463, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(243.56598, -110.16253, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(297.50284, -171.07893, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(333.7477, -192.4948, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(383.1555, -241.34106, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(388.30063, -333.57056, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(259.1318, -279.9861, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(176.85796, -278.7914, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(144.42758, -246.19345, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(206.51572, -393.95078, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(185.21767, -345.31256, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(256.63293, -328.11276, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(298.81674, -283.9012, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(62.857853, -336.97418, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(69.281555, -303.19885, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(156.33217, -313.2433, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(395.89896, -375.44592, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(419.0373, -409.6076, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-669.557, -465.96155, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-641.0392, -463.2385, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-663.7461, -423.68848, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-691.5367, -412.37482, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-654.67377, -377.6717, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-604.47437, -314.21817, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-623.4556, -282.80988, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-671.2002, -290.27917, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-601.60205, -206.68303, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-577.15283, -269.73874, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-641.7073, -153.51749, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-679.95447, -167.26642, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-616.99646, -183.22237, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-610.8949, -248.34499, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-695.4032, -253.39896, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-666.11255, -45.597427, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-656.8419, -1.3068886, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-709.7387, -48.356636, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-656.7067, 39.966724, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-676.6389, 4.448944, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-826.00385, 394.23685, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-802.1488, 469.5569, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-843.5389, 537.9395, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-797.06775, 590.18994, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-762.02905, 661.9221, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-813.3632, 625.5947, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-735.1721, 592.58325, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-765.74786, 525.04315, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-772.5334, 559.3963, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-677.49854, 603.98145, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-601.7097, 601.75964, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-619.1825, 515.2883, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-648.6541, 557.17487, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-703.02893, 517.3972, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-700.88385, 562.6249, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-642.6309, 489.1677, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-543.0344, 484.50873, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-514.75757, 429.53107, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-622.47253, 396.93286, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-585.3668, 457.55743, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-710.6922, 436.19955, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-736.31464, 468.98566, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-769.9273, 392.4338, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-722.5627, 387.5058, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-825.884, 321.0981, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-818.6602, 354.90582, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-673.5258, 324.61267, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-643.314, 370.83566, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-575.43976, 303.47974, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-512.2229, 384.2166, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-288.92676, 449.7934, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-275.0607, 482.7495, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-318.05008, 409.3732, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-316.56747, 447.35193, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-338.15927, 442.4363, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-238.6461, 58.816196, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-292.9822, -7.180003, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-271.73376, 38.37968, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-326.1296, -48.0757, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-290.6972, -117.11403, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-246.38177, -167.11047, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-206.4251, -103.58983, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-125.50208, -77.17986, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-141.45459, -121.82464, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-61.616257, -77.14221, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-33.855667, -25.639973, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-19.76313, 48.04596, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(31.853083, 90.77232, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-36.74762, 88.05092, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-125.80262, 32.857887, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-127.305, 68.190796, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-179.91339, 73.64577, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-61.644966, 56.86789, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-75.479515, -46.24231, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-38.887432, -106.33913, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-156.99742, -39.708206, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-196.31287, -51.61879, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-239.85149, -105.66035, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-228.33296, -29.538544, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-94.829926, -110.95627, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-12.446098, -168.5271, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-20.500132, -128.47746, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-87.206085, -167.47354, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-62.547054, -131.90146, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(-187.30966, -151.71408, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(111.91533, 645.3346, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(153.92743, 533.6098, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(179.72226, 590.19763, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(206.27867, 507.59286, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(169.77034, 454.46155, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(161.3288, 486.53302, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(99.22697, 517.1652, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(10.677752, 472.7102, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(26.941975, 519.1745, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(38.654453, 430.39423, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(28.703997, 380.908, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(7.83037, 423.1379, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(75.752365, 427.3962, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(95.849884, 362.79416, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(79.03023, 393.1916, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(124.71273, 440.5534, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(145.82933, 372.91388, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(131.37538, 405.21344, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(221.19275, 386.21237, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(255.70491, 486.97687, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(150.62454, 574.23004, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(182.38284, 413.73807, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(276.2045, 449.93616, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(249.2773, 407.21317, 25));
		AddSpawnPoint("f_flash_60.Id3", "f_flash_60", Rectangle(309.2456, 418.11298, 25));

		// 'Bavon' GenType 26 Spawn Points
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(399.05, 11.880619, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(-316.10684, -1097.7246, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(-723.4316, -981.88196, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(-691.8281, -850.0464, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(-90.99599, -0.40338677, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(71.301315, 472.07178, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(213.36652, 1193.1462, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(251.86707, 1453.625, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(713.80347, 1509.2546, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(879.8956, 1406.1752, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(-480.86926, -966.0756, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(-261.4649, -77.110794, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(141.36699, 604.7215, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(-194.79063, 478.81036, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(125.45002, 1313.1771, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(112.36478, 1057.1704, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(904.66486, 1563.4658, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(494.89957, 1480.9692, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(-241.0319, -959.4728, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(-497.98035, 337.85397, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(164.16194, -206.80989, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(-480.6344, -1105.7883, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(358.17523, -1066.5776, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(443.7356, -905.45685, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(236.81052, -842.61017, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(305.498, -930.64954, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(190.75746, -1162.1227, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(298.16718, -335.64334, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(-671.18097, -515.6375, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(-679.0078, -107.55698, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(-1247.1248, -332.87247, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(-1178.8496, -497.46286, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(-1329.5022, -1009.1072, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(-1211.4158, -773.92236, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(-1097.4762, -1037.0292, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(171.19353, 1059.9296, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(128.29236, 1015.1441, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(223.01387, 1080.2231, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(306.87418, 1060.1705, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(236.85898, 1156.7927, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(154.39832, 1107.4769, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(104.34515, 1163.7913, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(89.53244, 1215.3918, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(204.4893, 1237.4087, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(263.22495, 1295.0262, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(271.69504, 1352.03, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(232.61795, 1325.5349, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(144.75548, 1270.2914, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(153.09189, 1366.7501, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(114.79259, 1442.9042, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(174.40442, 1487.7621, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(137.87247, 1407.4076, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(254.37054, 1504.935, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(307.05234, 1510.6571, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(259.14307, 1418.5286, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(201.82605, 1456.1434, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(218.5328, 1533.5383, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(358.9514, 1559.012, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(344.05167, 1599.5465, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(107.7444, 1485.9678, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(660.18823, 1582.1151, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(558.7304, 1499.6746, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(597.36084, 1527.7075, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(598.68036, 1438.4961, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(604.9616, 1476.8457, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(593.13135, 1386.1127, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(627.09955, 1297.9154, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(661.5712, 1305.5225, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(638.50745, 1380.9669, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(696.43024, 1403.459, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(664.55804, 1440.9276, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(731.35205, 1456.9224, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(791.82715, 1556.8755, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(846.6157, 1587.9438, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(818.3996, 1474.653, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(751.71356, 1401.2797, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(829.3933, 1428.282, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(901.9532, 1453.2946, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(850.2554, 1522.2119, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(958.7537, 1590.9382, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(985.09985, 1546.202, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(921.4572, 1516.5132, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(975.44824, 1494.8363, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(950.95624, 1438.2252, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(998.14404, 1338.2006, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(960.50586, 1280.544, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(986.74036, 1242.7054, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(922.0412, 1192.9784, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(984.62354, 1201.1028, 25));
		AddSpawnPoint("f_flash_60.Id4", "f_flash_60", Rectangle(958.7086, 1301.8892, 25));

		// 'Saltisdaughter_Mage' GenType 27 Spawn Points
		AddSpawnPoint("f_flash_60.Id5", "f_flash_60", Rectangle(144.90091, 695.08624, 40));
		AddSpawnPoint("f_flash_60.Id5", "f_flash_60", Rectangle(280.86703, 316.89285, 40));
		AddSpawnPoint("f_flash_60.Id5", "f_flash_60", Rectangle(331.89813, -385.41714, 40));
		AddSpawnPoint("f_flash_60.Id5", "f_flash_60", Rectangle(149.05292, 1156.63, 40));
		AddSpawnPoint("f_flash_60.Id5", "f_flash_60", Rectangle(267.5772, 1566.3253, 40));
		AddSpawnPoint("f_flash_60.Id5", "f_flash_60", Rectangle(182.44788, 1314.4316, 40));
		AddSpawnPoint("f_flash_60.Id5", "f_flash_60", Rectangle(263.48474, -24.524326, 40));
		AddSpawnPoint("f_flash_60.Id5", "f_flash_60", Rectangle(-273.60846, -38.317368, 40));
		AddSpawnPoint("f_flash_60.Id5", "f_flash_60", Rectangle(0.6028261, -311.58395, 40));
		AddSpawnPoint("f_flash_60.Id5", "f_flash_60", Rectangle(443.9941, -42.22262, 40));
		AddSpawnPoint("f_flash_60.Id5", "f_flash_60", Rectangle(657.66046, 1497.8467, 40));
		AddSpawnPoint("f_flash_60.Id5", "f_flash_60", Rectangle(911.4375, 1312.5145, 40));
		AddSpawnPoint("f_flash_60.Id5", "f_flash_60", Rectangle(-659.4119, -219.6036, 40));
		AddSpawnPoint("f_flash_60.Id5", "f_flash_60", Rectangle(907.5981, 1599.307, 40));
		AddSpawnPoint("f_flash_60.Id5", "f_flash_60", Rectangle(240.10468, -180.46463, 40));
		AddSpawnPoint("f_flash_60.Id5", "f_flash_60", Rectangle(-360.90326, -1073.2294, 40));
		AddSpawnPoint("f_flash_60.Id5", "f_flash_60", Rectangle(-630.53546, -921.86395, 40));
		AddSpawnPoint("f_flash_60.Id5", "f_flash_60", Rectangle(-1297.8293, -1041.351, 40));
		AddSpawnPoint("f_flash_60.Id5", "f_flash_60", Rectangle(-1195.3389, -728.0105, 40));
		AddSpawnPoint("f_flash_60.Id5", "f_flash_60", Rectangle(-1134.0774, -380.68927, 40));

		// 'Rootcrystal_01' GenType 32 Spawn Points
		AddSpawnPoint("f_flash_60.Id6", "f_flash_60", Rectangle(881.0656, -383.53198, 100));
		AddSpawnPoint("f_flash_60.Id6", "f_flash_60", Rectangle(314.2281, -263.59497, 100));
		AddSpawnPoint("f_flash_60.Id6", "f_flash_60", Rectangle(175.16696, 497.35373, 100));
		AddSpawnPoint("f_flash_60.Id6", "f_flash_60", Rectangle(-148.57748, -37.016167, 100));
		AddSpawnPoint("f_flash_60.Id6", "f_flash_60", Rectangle(-1184.2373, 1279.4926, 100));
		AddSpawnPoint("f_flash_60.Id6", "f_flash_60", Rectangle(-1013.5612, 1124.4972, 100));
		AddSpawnPoint("f_flash_60.Id6", "f_flash_60", Rectangle(-795.5607, 558.1024, 100));
		AddSpawnPoint("f_flash_60.Id6", "f_flash_60", Rectangle(-670.4993, 400.16602, 100));
		AddSpawnPoint("f_flash_60.Id6", "f_flash_60", Rectangle(-1261.3214, 440.625, 100));
		AddSpawnPoint("f_flash_60.Id6", "f_flash_60", Rectangle(-622.4891, -159.15968, 100));
		AddSpawnPoint("f_flash_60.Id6", "f_flash_60", Rectangle(-735.3, -944.10583, 100));
		AddSpawnPoint("f_flash_60.Id6", "f_flash_60", Rectangle(-359.98853, -1026.7283, 100));
		AddSpawnPoint("f_flash_60.Id6", "f_flash_60", Rectangle(-177.83473, -966.95935, 100));
		AddSpawnPoint("f_flash_60.Id6", "f_flash_60", Rectangle(-1256.8152, -1073.2842, 100));
		AddSpawnPoint("f_flash_60.Id6", "f_flash_60", Rectangle(-1179.6521, -778.0437, 100));
		AddSpawnPoint("f_flash_60.Id6", "f_flash_60", Rectangle(-1202.3276, -370.1832, 100));
		AddSpawnPoint("f_flash_60.Id6", "f_flash_60", Rectangle(192.18263, 1120.0465, 100));
		AddSpawnPoint("f_flash_60.Id6", "f_flash_60", Rectangle(246.44347, 1329.4366, 100));
		AddSpawnPoint("f_flash_60.Id6", "f_flash_60", Rectangle(218.04169, 1562.3943, 100));
		AddSpawnPoint("f_flash_60.Id6", "f_flash_60", Rectangle(635.6044, 1506.217, 100));
		AddSpawnPoint("f_flash_60.Id6", "f_flash_60", Rectangle(859.54193, 1454.0692, 100));
		AddSpawnPoint("f_flash_60.Id6", "f_flash_60", Rectangle(377.11615, -1130.8142, 100));
		AddSpawnPoint("f_flash_60.Id6", "f_flash_60", Rectangle(434.86426, -925.1948, 100));

		// 'Saltisdaughter_Mage' GenType 1002 Spawn Points
		AddSpawnPoint("f_flash_60.Id7", "f_flash_60", Rectangle(-467.023, -1087.1564, 40));
		AddSpawnPoint("f_flash_60.Id7", "f_flash_60", Rectangle(177.21893, -224.21707, 40));
		AddSpawnPoint("f_flash_60.Id7", "f_flash_60", Rectangle(323.89557, 1311.1841, 40));
		AddSpawnPoint("f_flash_60.Id7", "f_flash_60", Rectangle(588.16956, 1342.425, 40));
		AddSpawnPoint("f_flash_60.Id7", "f_flash_60", Rectangle(-697.29236, -984.5274, 40));
		AddSpawnPoint("f_flash_60.Id7", "f_flash_60", Rectangle(-271.29254, -908.7257, 40));
		AddSpawnPoint("f_flash_60.Id7", "f_flash_60", Rectangle(338.8219, -448.27103, 40));
		AddSpawnPoint("f_flash_60.Id7", "f_flash_60", Rectangle(482.1339, -41.107418, 40));
		AddSpawnPoint("f_flash_60.Id7", "f_flash_60", Rectangle(98.395096, 1124.0396, 40));
		AddSpawnPoint("f_flash_60.Id7", "f_flash_60", Rectangle(151.67778, 1536.227, 40));
		AddSpawnPoint("f_flash_60.Id7", "f_flash_60", Rectangle(601.30865, 1595.5957, 40));
		AddSpawnPoint("f_flash_60.Id7", "f_flash_60", Rectangle(952.8249, 1367.9484, 40));
	}
}
