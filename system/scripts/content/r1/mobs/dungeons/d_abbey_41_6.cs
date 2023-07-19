//--- Melia Script -----------------------------------------------------------
// d_abbey_41_6
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Maven Abbey' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DAbbey416MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners ---------------------------------

		AddSpawner("d_abbey_41_6.Id1", MonsterId.Rootcrystal_01, 12, 16, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("d_abbey_41_6.Id2", MonsterId.Ticen_Bow_Red, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_abbey_41_6.Id3", MonsterId.Ticen_Red, 105, 140, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_abbey_41_6.Id4", MonsterId.Ticen_Mage_Red, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_abbey_41_6.Id5", MonsterId.Nuo_Red, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_abbey_41_6.Id6", MonsterId.Ticen_Mage_Red, 2, 2, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_01' GenType 2 Spawn Points
		AddSpawnPoint("d_abbey_41_6.Id1", "d_abbey_41_6", Rectangle(-672.19196, -1443.6582, 50));
		AddSpawnPoint("d_abbey_41_6.Id1", "d_abbey_41_6", Rectangle(-723.93115, -1040.6302, 50));
		AddSpawnPoint("d_abbey_41_6.Id1", "d_abbey_41_6", Rectangle(-819.4157, -722.72864, 50));
		AddSpawnPoint("d_abbey_41_6.Id1", "d_abbey_41_6", Rectangle(-568.715, -820.3939, 50));
		AddSpawnPoint("d_abbey_41_6.Id1", "d_abbey_41_6", Rectangle(-306.21136, -879.04193, 50));
		AddSpawnPoint("d_abbey_41_6.Id1", "d_abbey_41_6", Rectangle(-142.25787, -1090.2874, 50));
		AddSpawnPoint("d_abbey_41_6.Id1", "d_abbey_41_6", Rectangle(-16.912825, -898.28613, 50));
		AddSpawnPoint("d_abbey_41_6.Id1", "d_abbey_41_6", Rectangle(122.57979, -736.36444, 50));
		AddSpawnPoint("d_abbey_41_6.Id1", "d_abbey_41_6", Rectangle(280.09033, -337.91193, 50));
		AddSpawnPoint("d_abbey_41_6.Id1", "d_abbey_41_6", Rectangle(413.2021, -651.0377, 50));
		AddSpawnPoint("d_abbey_41_6.Id1", "d_abbey_41_6", Rectangle(614.98663, -440.71088, 50));
		AddSpawnPoint("d_abbey_41_6.Id1", "d_abbey_41_6", Rectangle(471.1905, -92.37758, 50));
		AddSpawnPoint("d_abbey_41_6.Id1", "d_abbey_41_6", Rectangle(795.6318, -255.21811, 50));
		AddSpawnPoint("d_abbey_41_6.Id1", "d_abbey_41_6", Rectangle(720.7905, 81.24414, 50));
		AddSpawnPoint("d_abbey_41_6.Id1", "d_abbey_41_6", Rectangle(-306.1287, -170.98431, 50));
		AddSpawnPoint("d_abbey_41_6.Id1", "d_abbey_41_6", Rectangle(39.601746, 184.70868, 50));
		AddSpawnPoint("d_abbey_41_6.Id1", "d_abbey_41_6", Rectangle(494.31598, 499.1725, 50));
		AddSpawnPoint("d_abbey_41_6.Id1", "d_abbey_41_6", Rectangle(709.02673, -1052.0337, 50));
		AddSpawnPoint("d_abbey_41_6.Id1", "d_abbey_41_6", Rectangle(1052.0508, -845.8561, 50));
		AddSpawnPoint("d_abbey_41_6.Id1", "d_abbey_41_6", Rectangle(1381.3856, -442.32483, 50));
		AddSpawnPoint("d_abbey_41_6.Id1", "d_abbey_41_6", Rectangle(1009.7322, 430.42407, 50));
		AddSpawnPoint("d_abbey_41_6.Id1", "d_abbey_41_6", Rectangle(1528.2562, 262.3002, 50));
		AddSpawnPoint("d_abbey_41_6.Id1", "d_abbey_41_6", Rectangle(1396.5388, 802.82007, 50));
		AddSpawnPoint("d_abbey_41_6.Id1", "d_abbey_41_6", Rectangle(1473.2072, 570.21265, 50));
		AddSpawnPoint("d_abbey_41_6.Id1", "d_abbey_41_6", Rectangle(999.1199, 796.93396, 50));

		// 'Ticen_Bow_Red' GenType 300 Spawn Points
		AddSpawnPoint("d_abbey_41_6.Id2", "d_abbey_41_6", Rectangle(1037.1179, 471.76038, 25));
		AddSpawnPoint("d_abbey_41_6.Id2", "d_abbey_41_6", Rectangle(1130.0502, 753.4606, 25));
		AddSpawnPoint("d_abbey_41_6.Id2", "d_abbey_41_6", Rectangle(1649.6537, 324.12973, 25));
		AddSpawnPoint("d_abbey_41_6.Id2", "d_abbey_41_6", Rectangle(1393.7552, 215.25043, 25));
		AddSpawnPoint("d_abbey_41_6.Id2", "d_abbey_41_6", Rectangle(1154.5957, 593.8493, 25));
		AddSpawnPoint("d_abbey_41_6.Id2", "d_abbey_41_6", Rectangle(1370.0035, 756.8363, 25));
		AddSpawnPoint("d_abbey_41_6.Id2", "d_abbey_41_6", Rectangle(1538.4163, 428.47577, 25));
		AddSpawnPoint("d_abbey_41_6.Id2", "d_abbey_41_6", Rectangle(1256.4636, 404.69604, 25));
		AddSpawnPoint("d_abbey_41_6.Id2", "d_abbey_41_6", Rectangle(-574.7041, -1317.0231, 25));
		AddSpawnPoint("d_abbey_41_6.Id2", "d_abbey_41_6", Rectangle(1164.3986, -453.09167, 25));
		AddSpawnPoint("d_abbey_41_6.Id2", "d_abbey_41_6", Rectangle(1280.1144, -577.5289, 25));
		AddSpawnPoint("d_abbey_41_6.Id2", "d_abbey_41_6", Rectangle(1414.6262, -530.5205, 25));
		AddSpawnPoint("d_abbey_41_6.Id2", "d_abbey_41_6", Rectangle(1274.5571, -297.6743, 25));
		AddSpawnPoint("d_abbey_41_6.Id2", "d_abbey_41_6", Rectangle(1295.2311, -482.4483, 25));
		AddSpawnPoint("d_abbey_41_6.Id2", "d_abbey_41_6", Rectangle(268.16238, 506.97784, 25));
		AddSpawnPoint("d_abbey_41_6.Id2", "d_abbey_41_6", Rectangle(386.8516, 643.6772, 25));
		AddSpawnPoint("d_abbey_41_6.Id2", "d_abbey_41_6", Rectangle(504.50525, 555.6291, 25));
		AddSpawnPoint("d_abbey_41_6.Id2", "d_abbey_41_6", Rectangle(528.5978, 185.50534, 25));
		AddSpawnPoint("d_abbey_41_6.Id2", "d_abbey_41_6", Rectangle(28.6419, 107.36116, 25));
		AddSpawnPoint("d_abbey_41_6.Id2", "d_abbey_41_6", Rectangle(-56.860695, 204.58586, 25));
		AddSpawnPoint("d_abbey_41_6.Id2", "d_abbey_41_6", Rectangle(132.9626, 269.34412, 25));
		AddSpawnPoint("d_abbey_41_6.Id2", "d_abbey_41_6", Rectangle(219.41327, 17.865704, 25));
		AddSpawnPoint("d_abbey_41_6.Id2", "d_abbey_41_6", Rectangle(848.1817, -741.5741, 25));
		AddSpawnPoint("d_abbey_41_6.Id2", "d_abbey_41_6", Rectangle(987.1356, -596.029, 25));
		AddSpawnPoint("d_abbey_41_6.Id2", "d_abbey_41_6", Rectangle(759.4903, -552.36304, 25));
		AddSpawnPoint("d_abbey_41_6.Id2", "d_abbey_41_6", Rectangle(585.03986, 83.80991, 25));
		AddSpawnPoint("d_abbey_41_6.Id2", "d_abbey_41_6", Rectangle(880.42847, -212.08136, 25));
		AddSpawnPoint("d_abbey_41_6.Id2", "d_abbey_41_6", Rectangle(641.7667, -338.00906, 25));
		AddSpawnPoint("d_abbey_41_6.Id2", "d_abbey_41_6", Rectangle(528.3263, -482.90765, 25));
		AddSpawnPoint("d_abbey_41_6.Id2", "d_abbey_41_6", Rectangle(297.59882, -280.06143, 25));
		AddSpawnPoint("d_abbey_41_6.Id2", "d_abbey_41_6", Rectangle(566.81573, -85.46454, 25));
		AddSpawnPoint("d_abbey_41_6.Id2", "d_abbey_41_6", Rectangle(239.66916, -55.949745, 25));
		AddSpawnPoint("d_abbey_41_6.Id2", "d_abbey_41_6", Rectangle(392.02014, -151.32428, 25));
		AddSpawnPoint("d_abbey_41_6.Id2", "d_abbey_41_6", Rectangle(182.09203, -361.20605, 25));
		AddSpawnPoint("d_abbey_41_6.Id2", "d_abbey_41_6", Rectangle(-74.52292, -235.66054, 25));
		AddSpawnPoint("d_abbey_41_6.Id2", "d_abbey_41_6", Rectangle(68.72459, -393.74225, 25));
		AddSpawnPoint("d_abbey_41_6.Id2", "d_abbey_41_6", Rectangle(313.24286, -602.09033, 25));
		AddSpawnPoint("d_abbey_41_6.Id2", "d_abbey_41_6", Rectangle(435.02036, -750.1305, 25));

		// 'Ticen_Red' GenType 301 Spawn Points
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(1549.2103, 892.578, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-813.0704, -1409.548, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-823.383, -1303.3585, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-599.71124, -1494.8877, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-644.31934, -1329.5841, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(1157.6454, -446.3039, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(1208.4592, -390.00873, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(302.55902, 505.47873, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(538.54926, 187.25641, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(584.4864, -470.5543, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(430.27545, -540.88214, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(205.44162, -467.44644, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(375.7953, -692.5881, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-19.370094, -302.3784, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(240.72833, -40.342056, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(703.1455, -963.04236, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(658.5809, -1132.7375, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(158.75504, -734.0682, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-11.779387, -935.3723, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-119.65896, -1081.0417, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-185.2312, -1122.7224, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-209.23729, -857.3974, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-828.8936, -978.1608, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-815.1161, -765.72833, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-589.51746, -716.15344, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-678.1505, -959.6803, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-643.0184, -1084.3115, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-525.58856, -903.0499, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-694.5888, -1373.0823, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-667.62994, -1440.9634, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-775.97864, -1516.73, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-682.7991, -1524.858, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-715.51074, -1165.7047, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-624.72046, -1543.7618, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-549.9853, -1453.9542, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-652.1227, -1383.9651, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-747.0054, -1392.1841, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-807.3362, -1459.1222, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-732.2557, -1545.63, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-726.8368, -1494.958, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-698.2945, -1307.3401, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-695.88654, -1243.3951, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-708.63055, -1089.3812, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-673.8809, -1141.3823, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-659.85565, -1014.7892, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-769.0616, -1045.1597, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-774.7654, -986.18915, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-773.9391, -900.99054, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-814.23376, -843.7588, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-859.79443, -830.21796, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-867.958, -751.6831, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-791.24384, -700.7794, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-728.6486, -703.3131, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-760.4165, -777.9858, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-705.57526, -767.7543, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-735.29364, -843.3991, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-625.4511, -919.6736, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-718.3208, -915.3315, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-651.90265, -695.3204, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-562.1679, -785.7962, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-612.6336, -793.79846, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-508.29764, -817.5318, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-567.39105, -928.1208, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-514.32715, -1005.024, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-540.93665, -1048.6284, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-597.05707, -1038.8757, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-608.0378, -979.32135, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-474.44928, -867.83014, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-289.82214, -802.3592, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-203.39267, -786.36566, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-159.76485, -829.15576, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-249.12985, -885.0514, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-281.07886, -855.52704, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-300.41412, -910.42523, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-204.02306, -924.9323, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-173.42714, -959.194, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-217.07722, -988.2257, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-298.60846, -968.9492, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-317.79022, -1051.5266, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-317.149, -1111.7408, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-271.21533, -1138.3715, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-252.70522, -1082.8091, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-134.38536, -1131.9243, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-17.63485, -834.1015, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(44.351307, -920.5562, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(23.22546, -995.53033, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(12.55331, -1051.8191, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-45.557983, -1106.404, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-86.778595, -1139.2828, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-5.2770348, -1142.098, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(43.940342, -1102.0164, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-119.07449, -968.18823, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-67.00286, -895.07166, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(44.410187, -851.9834, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(31.658058, -797.1787, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-157.35696, -41.68919, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-324.10144, -183.47415, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-242.26003, -355.4362, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-441.593, -178.05542, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(101.42426, -365.56085, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(104.98344, -457.23544, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(287.62082, -335.88217, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(252.68677, -243.97095, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(686.1463, -365.6967, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(303.6091, -530.7196, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(518.81464, -370.77554, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(318.8864, -647.7565, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(440.14365, -441.06198, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(390.2882, -305.5507, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(457.2272, -239.43404, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(510.2775, -140.24054, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(485.2452, 20.043697, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(581.6129, 52.938923, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(842.43207, -59.689606, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(937.0233, -146.42618, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(694.01294, -50.048386, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(599.95874, -381.74326, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-18.039066, 76.270905, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(30.501612, 302.62943, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(97.775085, 340.23248, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(-85.704315, 188.27606, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(205.19359, 72.34848, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(334.73447, -105.74399, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(460.50186, 635.47784, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(605.09937, 471.15332, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(373.44644, 331.15103, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(264.00803, 405.33423, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(658.1313, 123.71948, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(747.33307, -241.54593, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(702.55176, -1297.7402, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(810.07367, -1046.7133, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(726.57117, -1076.5002, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(631.2913, -999.76495, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(543.28107, -1033.9557, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(586.1483, -933.38275, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(453.51807, -1051.3969, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(791.57837, -1216.4022, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(888.9857, -1109.7657, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(532.5634, -1165.4489, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(1080.391, -917.53015, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(1124.8379, -873.7576, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(1179.2078, -825.98065, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(1157.8284, -743.55853, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(1131.4421, -677.9031, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(1060.9233, -722.0746, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(1028.6023, -816.60516, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(856.89166, -788.99506, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(983.9988, -731.9832, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(943.53485, -634.57666, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(774.9964, -727.38226, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(870.26874, -623.8585, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(958.6161, -550.27905, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(1051.5859, -915.44653, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(1344.9608, -566.12897, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(1428.4954, -489.80566, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(1510.8494, -442.6426, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(1293.2079, -402.68222, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(1249.489, -509.85785, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(1338.3003, -276.5337, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(1434.8625, -356.26788, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(1251.068, -241.54369, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(1125.1501, -360.22845, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(1358.1329, 61.85719, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(1378.5347, 542.3897, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(1116.5187, 276.04224, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(1142.5452, 145.31273, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(940.82135, 356.59912, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(970.14716, 725.109, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(1318.5511, 945.7903, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(1422.0491, 790.5587, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(1546.2118, 388.10303, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(1778.7427, 510.83026, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(1622.9838, 181.78152, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(1617.2572, 726.57263, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(1201.7606, 773.2002, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(1111.0142, 514.2692, 25));
		AddSpawnPoint("d_abbey_41_6.Id3", "d_abbey_41_6", Rectangle(1278.4213, 541.24133, 25));

		// 'Ticen_Mage_Red' GenType 302 Spawn Points
		AddSpawnPoint("d_abbey_41_6.Id4", "d_abbey_41_6", Rectangle(198.6904, -454.69583, 25));
		AddSpawnPoint("d_abbey_41_6.Id4", "d_abbey_41_6", Rectangle(332.02838, -324.3338, 25));
		AddSpawnPoint("d_abbey_41_6.Id4", "d_abbey_41_6", Rectangle(427.40118, -154.68399, 25));
		AddSpawnPoint("d_abbey_41_6.Id4", "d_abbey_41_6", Rectangle(725.38715, 56.072224, 25));
		AddSpawnPoint("d_abbey_41_6.Id4", "d_abbey_41_6", Rectangle(870.3592, -156.22461, 25));
		AddSpawnPoint("d_abbey_41_6.Id4", "d_abbey_41_6", Rectangle(739.918, -366.48035, 25));
		AddSpawnPoint("d_abbey_41_6.Id4", "d_abbey_41_6", Rectangle(600.4677, -503.6615, 25));
		AddSpawnPoint("d_abbey_41_6.Id4", "d_abbey_41_6", Rectangle(372.39014, -699.5544, 25));
		AddSpawnPoint("d_abbey_41_6.Id4", "d_abbey_41_6", Rectangle(1263.9026, 456.4844, 25));
		AddSpawnPoint("d_abbey_41_6.Id4", "d_abbey_41_6", Rectangle(1402.2609, 637.9414, 25));
		AddSpawnPoint("d_abbey_41_6.Id4", "d_abbey_41_6", Rectangle(1365.7583, 344.95056, 25));
		AddSpawnPoint("d_abbey_41_6.Id4", "d_abbey_41_6", Rectangle(1477.8955, 399.51645, 25));
		AddSpawnPoint("d_abbey_41_6.Id4", "d_abbey_41_6", Rectangle(-446.47873, -173.08124, 25));
		AddSpawnPoint("d_abbey_41_6.Id4", "d_abbey_41_6", Rectangle(-186.7158, -102.83385, 25));
		AddSpawnPoint("d_abbey_41_6.Id4", "d_abbey_41_6", Rectangle(-294.88028, -206.54602, 25));
		AddSpawnPoint("d_abbey_41_6.Id4", "d_abbey_41_6", Rectangle(500.56958, -1075.4481, 25));
		AddSpawnPoint("d_abbey_41_6.Id4", "d_abbey_41_6", Rectangle(697.8984, -901.2851, 25));
		AddSpawnPoint("d_abbey_41_6.Id4", "d_abbey_41_6", Rectangle(780.4061, -993.67786, 25));
		AddSpawnPoint("d_abbey_41_6.Id4", "d_abbey_41_6", Rectangle(697.807, -1084.4573, 25));
		AddSpawnPoint("d_abbey_41_6.Id4", "d_abbey_41_6", Rectangle(676.7263, -1245.9832, 25));
		AddSpawnPoint("d_abbey_41_6.Id4", "d_abbey_41_6", Rectangle(382.48645, -529.1907, 25));
		AddSpawnPoint("d_abbey_41_6.Id4", "d_abbey_41_6", Rectangle(688.09515, -233.80922, 25));
		AddSpawnPoint("d_abbey_41_6.Id4", "d_abbey_41_6", Rectangle(975.4485, -811.74274, 25));
		AddSpawnPoint("d_abbey_41_6.Id4", "d_abbey_41_6", Rectangle(1115.9199, -727.2054, 25));
		AddSpawnPoint("d_abbey_41_6.Id4", "d_abbey_41_6", Rectangle(1264.5942, -442.99503, 25));
		AddSpawnPoint("d_abbey_41_6.Id4", "d_abbey_41_6", Rectangle(1437.6053, -397.42322, 25));
		AddSpawnPoint("d_abbey_41_6.Id4", "d_abbey_41_6", Rectangle(1315.2861, -250.24535, 25));
		AddSpawnPoint("d_abbey_41_6.Id4", "d_abbey_41_6", Rectangle(1177.6938, -363.8146, 25));
		AddSpawnPoint("d_abbey_41_6.Id4", "d_abbey_41_6", Rectangle(38.70871, 155.30682, 25));
		AddSpawnPoint("d_abbey_41_6.Id4", "d_abbey_41_6", Rectangle(46.398335, 255.7559, 25));
		AddSpawnPoint("d_abbey_41_6.Id4", "d_abbey_41_6", Rectangle(370.12527, 579.4123, 25));
		AddSpawnPoint("d_abbey_41_6.Id4", "d_abbey_41_6", Rectangle(508.278, 589.5437, 25));
		AddSpawnPoint("d_abbey_41_6.Id4", "d_abbey_41_6", Rectangle(491.55652, 188.04533, 25));
		AddSpawnPoint("d_abbey_41_6.Id4", "d_abbey_41_6", Rectangle(575.38586, -93.96654, 25));
		AddSpawnPoint("d_abbey_41_6.Id4", "d_abbey_41_6", Rectangle(258.00208, -115.04504, 25));
		AddSpawnPoint("d_abbey_41_6.Id4", "d_abbey_41_6", Rectangle(1090.7404, 253.05223, 25));
		AddSpawnPoint("d_abbey_41_6.Id4", "d_abbey_41_6", Rectangle(1008.4401, 640.3003, 25));
		AddSpawnPoint("d_abbey_41_6.Id4", "d_abbey_41_6", Rectangle(1287.1989, 890.64716, 25));
		AddSpawnPoint("d_abbey_41_6.Id4", "d_abbey_41_6", Rectangle(1592.217, 850.21643, 25));
		AddSpawnPoint("d_abbey_41_6.Id4", "d_abbey_41_6", Rectangle(1722.7208, 535.3979, 25));
		AddSpawnPoint("d_abbey_41_6.Id4", "d_abbey_41_6", Rectangle(1390.1853, 131.60934, 25));
		AddSpawnPoint("d_abbey_41_6.Id4", "d_abbey_41_6", Rectangle(-271.13046, -1028.5212, 25));
		AddSpawnPoint("d_abbey_41_6.Id4", "d_abbey_41_6", Rectangle(-61.779003, -1039.4897, 25));
		AddSpawnPoint("d_abbey_41_6.Id4", "d_abbey_41_6", Rectangle(-162.76828, -888.99054, 25));
		AddSpawnPoint("d_abbey_41_6.Id4", "d_abbey_41_6", Rectangle(-244.05342, -831.3626, 25));
		AddSpawnPoint("d_abbey_41_6.Id4", "d_abbey_41_6", Rectangle(-117.29761, -794.3702, 25));
		AddSpawnPoint("d_abbey_41_6.Id4", "d_abbey_41_6", Rectangle(-591.63617, -874.1341, 25));
		AddSpawnPoint("d_abbey_41_6.Id4", "d_abbey_41_6", Rectangle(-727.23303, -999.01605, 25));
		AddSpawnPoint("d_abbey_41_6.Id4", "d_abbey_41_6", Rectangle(-856.3523, -898.28375, 25));
		AddSpawnPoint("d_abbey_41_6.Id4", "d_abbey_41_6", Rectangle(-686.58704, -660.10297, 25));

		// 'Nuo_Red' GenType 303 Spawn Points
		AddSpawnPoint("d_abbey_41_6.Id5", "d_abbey_41_6", Rectangle(-852.9019, -958.2761, 25));
		AddSpawnPoint("d_abbey_41_6.Id5", "d_abbey_41_6", Rectangle(-805.6264, -788.83984, 25));
		AddSpawnPoint("d_abbey_41_6.Id5", "d_abbey_41_6", Rectangle(-613.9759, -726.9809, 25));
		AddSpawnPoint("d_abbey_41_6.Id5", "d_abbey_41_6", Rectangle(-673.85895, -958.05597, 25));
		AddSpawnPoint("d_abbey_41_6.Id5", "d_abbey_41_6", Rectangle(-364.3407, -837.50006, 25));
		AddSpawnPoint("d_abbey_41_6.Id5", "d_abbey_41_6", Rectangle(-180.35458, -1037.81, 25));
		AddSpawnPoint("d_abbey_41_6.Id5", "d_abbey_41_6", Rectangle(-70.13109, -850.37036, 25));
		AddSpawnPoint("d_abbey_41_6.Id5", "d_abbey_41_6", Rectangle(-47.761314, -957.32074, 25));
		AddSpawnPoint("d_abbey_41_6.Id5", "d_abbey_41_6", Rectangle(175.2114, -741.4829, 25));
		AddSpawnPoint("d_abbey_41_6.Id5", "d_abbey_41_6", Rectangle(321.1395, -582.7488, 25));
		AddSpawnPoint("d_abbey_41_6.Id5", "d_abbey_41_6", Rectangle(100.14723, -442.79633, 25));
		AddSpawnPoint("d_abbey_41_6.Id5", "d_abbey_41_6", Rectangle(315.44238, -274.54926, 25));
		AddSpawnPoint("d_abbey_41_6.Id5", "d_abbey_41_6", Rectangle(554.7931, -53.349987, 25));
		AddSpawnPoint("d_abbey_41_6.Id5", "d_abbey_41_6", Rectangle(732.11975, -6.952078, 25));
		AddSpawnPoint("d_abbey_41_6.Id5", "d_abbey_41_6", Rectangle(794.2769, -247.36539, 25));
		AddSpawnPoint("d_abbey_41_6.Id5", "d_abbey_41_6", Rectangle(512.7726, -521.0263, 25));
		AddSpawnPoint("d_abbey_41_6.Id5", "d_abbey_41_6", Rectangle(635.91437, -923.2657, 25));
		AddSpawnPoint("d_abbey_41_6.Id5", "d_abbey_41_6", Rectangle(687.3251, -1127.3328, 25));
		AddSpawnPoint("d_abbey_41_6.Id5", "d_abbey_41_6", Rectangle(896.61804, -702.8281, 25));
		AddSpawnPoint("d_abbey_41_6.Id5", "d_abbey_41_6", Rectangle(1042.9421, -672.39166, 25));
		AddSpawnPoint("d_abbey_41_6.Id5", "d_abbey_41_6", Rectangle(1382.9532, -477.3103, 25));
		AddSpawnPoint("d_abbey_41_6.Id5", "d_abbey_41_6", Rectangle(378.69745, 462.2521, 25));
		AddSpawnPoint("d_abbey_41_6.Id5", "d_abbey_41_6", Rectangle(380.1368, 629.6328, 25));
		AddSpawnPoint("d_abbey_41_6.Id5", "d_abbey_41_6", Rectangle(263.2655, 507.40366, 25));
		AddSpawnPoint("d_abbey_41_6.Id5", "d_abbey_41_6", Rectangle(59.348465, 240.95607, 25));
		AddSpawnPoint("d_abbey_41_6.Id5", "d_abbey_41_6", Rectangle(-43.507202, 126.53328, 25));
		AddSpawnPoint("d_abbey_41_6.Id5", "d_abbey_41_6", Rectangle(140.1178, 69.75229, 25));
		AddSpawnPoint("d_abbey_41_6.Id5", "d_abbey_41_6", Rectangle(-312.65628, -90.59747, 25));
		AddSpawnPoint("d_abbey_41_6.Id5", "d_abbey_41_6", Rectangle(-396.11478, -239.58423, 25));
		AddSpawnPoint("d_abbey_41_6.Id5", "d_abbey_41_6", Rectangle(-71.887054, -207.36996, 25));
		AddSpawnPoint("d_abbey_41_6.Id5", "d_abbey_41_6", Rectangle(1316.8073, 483.1019, 25));
		AddSpawnPoint("d_abbey_41_6.Id5", "d_abbey_41_6", Rectangle(1024.9893, 474.0791, 25));
		AddSpawnPoint("d_abbey_41_6.Id5", "d_abbey_41_6", Rectangle(1406.685, 822.59564, 25));
		AddSpawnPoint("d_abbey_41_6.Id5", "d_abbey_41_6", Rectangle(1656.0504, 667.08997, 25));
		AddSpawnPoint("d_abbey_41_6.Id5", "d_abbey_41_6", Rectangle(1646.0762, 435.35678, 25));
		AddSpawnPoint("d_abbey_41_6.Id5", "d_abbey_41_6", Rectangle(1512.0549, 228.15092, 25));
		AddSpawnPoint("d_abbey_41_6.Id5", "d_abbey_41_6", Rectangle(1274.042, 265.54764, 25));
		AddSpawnPoint("d_abbey_41_6.Id5", "d_abbey_41_6", Rectangle(1101.6865, 696.09753, 25));
		AddSpawnPoint("d_abbey_41_6.Id5", "d_abbey_41_6", Rectangle(1453.2485, 633.3823, 25));

		// 'Ticen_Mage_Red' GenType 304 Spawn Points
		AddSpawnPoint("d_abbey_41_6.Id6", "d_abbey_41_6", Rectangle(-752.42145, -1329.3811, 25));
		AddSpawnPoint("d_abbey_41_6.Id6", "d_abbey_41_6", Rectangle(-735.15753, -1453.3661, 25));
		AddSpawnPoint("d_abbey_41_6.Id6", "d_abbey_41_6", Rectangle(-602.4363, -1402.8965, 25));
	}
}
