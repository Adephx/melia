//--- Melia Script -----------------------------------------------------------
// f_tableland_28_1
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Mesafasla' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FTableland281MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners ---------------------------------

		AddSpawner("f_tableland_28_1.Id1", MonsterId.Rootcrystal_03, 10, 13, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("f_tableland_28_1.Id2", MonsterId.Repusbunny_Green, 113, 150, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_tableland_28_1.Id3", MonsterId.Repusbunny_Bow_Green, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_tableland_28_1.Id4", MonsterId.Saltisdaughter_Mage_Red, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_03' GenType 4 Spawn Points
		AddSpawnPoint("f_tableland_28_1.Id1", "f_tableland_28_1", Rectangle(2.8408165, -524.4103, 50));
		AddSpawnPoint("f_tableland_28_1.Id1", "f_tableland_28_1", Rectangle(1219.5177, -609.0739, 50));
		AddSpawnPoint("f_tableland_28_1.Id1", "f_tableland_28_1", Rectangle(1528.8616, -431.62653, 50));
		AddSpawnPoint("f_tableland_28_1.Id1", "f_tableland_28_1", Rectangle(2020.2548, -107.01742, 50));
		AddSpawnPoint("f_tableland_28_1.Id1", "f_tableland_28_1", Rectangle(2257.6274, 205.06879, 50));
		AddSpawnPoint("f_tableland_28_1.Id1", "f_tableland_28_1", Rectangle(1937.7372, 599.0522, 50));
		AddSpawnPoint("f_tableland_28_1.Id1", "f_tableland_28_1", Rectangle(678.7784, -17.683138, 50));
		AddSpawnPoint("f_tableland_28_1.Id1", "f_tableland_28_1", Rectangle(710.7136, 308.31, 50));
		AddSpawnPoint("f_tableland_28_1.Id1", "f_tableland_28_1", Rectangle(327.10114, 236.63885, 50));
		AddSpawnPoint("f_tableland_28_1.Id1", "f_tableland_28_1", Rectangle(-128.66335, 231.04144, 50));
		AddSpawnPoint("f_tableland_28_1.Id1", "f_tableland_28_1", Rectangle(-442.2072, 387.33026, 50));
		AddSpawnPoint("f_tableland_28_1.Id1", "f_tableland_28_1", Rectangle(-681.9301, 616.0018, 50));
		AddSpawnPoint("f_tableland_28_1.Id1", "f_tableland_28_1", Rectangle(-969.0644, 699.4119, 50));
		AddSpawnPoint("f_tableland_28_1.Id1", "f_tableland_28_1", Rectangle(-1257.2817, 165.16887, 50));
		AddSpawnPoint("f_tableland_28_1.Id1", "f_tableland_28_1", Rectangle(-758.89966, 1081.2393, 50));
		AddSpawnPoint("f_tableland_28_1.Id1", "f_tableland_28_1", Rectangle(-778.1956, 1483.7043, 50));
		AddSpawnPoint("f_tableland_28_1.Id1", "f_tableland_28_1", Rectangle(-1712.9126, 602.97546, 50));
		AddSpawnPoint("f_tableland_28_1.Id1", "f_tableland_28_1", Rectangle(-1710.518, 1105.2148, 50));
		AddSpawnPoint("f_tableland_28_1.Id1", "f_tableland_28_1", Rectangle(-1431.2659, 1313.1316, 50));
		AddSpawnPoint("f_tableland_28_1.Id1", "f_tableland_28_1", Rectangle(-2195.3308, 1317.9509, 50));
		AddSpawnPoint("f_tableland_28_1.Id1", "f_tableland_28_1", Rectangle(-2819.582, 1055.2588, 50));
		AddSpawnPoint("f_tableland_28_1.Id1", "f_tableland_28_1", Rectangle(-3211.1855, 885.409, 50));

		// 'Repusbunny_Green' GenType 32 Spawn Points
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1963.7229, 537.7066, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1758.809, -184.439, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1141.5172, -640.88727, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1421.177, -366.09714, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(546.41754, 289.47305, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(803.4686, 129.58688, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(502.46167, 392.23074, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-616.70776, 557.8091, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-334.54755, 298.13474, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(10.397789, 234.33116, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1329.8936, -37.470863, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1762.3063, -195.50963, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1294.8119, -361.71524, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1529.4573, 124.42268, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-903.7919, 464.91107, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1047.9271, 650.68646, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-809.7748, 1044.1924, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1681.7468, 1247.855, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1290.1086, 1388.4998, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1785.469, 971.5759, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-3125.868, 1089.8477, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1548.4364, 1394.6985, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-3030.5732, 1193.8129, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-3258.9937, 1075.5364, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-2594.5151, 1261.68, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-2357.7583, 1307.4285, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-2053.926, 1356.6731, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1372.5708, -812.2434, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1514.2988, -914.4249, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1634.2893, -881.4205, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1749.1876, -801.9437, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1792.4288, -681.7198, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1717.2618, -541.2407, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1656.6268, -705.6877, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1415.2383, -525.23035, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1612.2424, -417.9924, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1562.7926, -547.5047, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1567.0488, -784.8697, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1409.3224, -688.23987, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1245.2316, -714.9796, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1274.4249, -562.40283, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1271.5527, -850.96265, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1142.4681, -800.92816, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1058.6809, -698.00684, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1066.2433, -507.93832, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1032.706, -380.8767, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1124.512, -288.581, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1253.0404, -230.38913, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1183.4967, -411.0204, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1439.8335, -207.7306, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1608.0903, -219.112, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1286.7753, -341.32385, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1715.987, -354.97604, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1894.5792, -119.24091, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1962.6256, -98.35873, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1958.053, -179.64558, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(2012.9758, -225.37442, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(2025.8888, -141.38785, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(2021.1482, -60.157543, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(2073.1267, -178.1559, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(2038.9911, 477.03125, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(2102.5823, 396.52844, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(2200.3171, 269.47998, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1715.0981, 939.253, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1703.9856, 863.8276, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1665.2977, 957.0629, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1651.8887, 853.86554, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1664.956, 808.3073, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1712.7781, 795.4717, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1757.9597, 824.3064, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1773.8457, 768.1574, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1808.2955, 711.32776, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-4.9174423, -598.1028, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-70.24279, -643.77905, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-166.08156, -667.12225, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-162.9632, -535.62177, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-21.081188, -477.2313, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(99.91028, -305.79117, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(101.20545, -552.1197, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(54.712387, -417.9796, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(23.92543, -733.6414, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(134.35774, -629.5175, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-172.8933, -436.54974, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-65.80178, -367.3063, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(171.93, -429.04968, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(741.1831, -110.16203, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(779.8899, 41.181343, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(831.66693, -56.839424, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(916.5097, 72.24783, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(930.0251, 190.22337, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(825.7781, 203.82831, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(803.4954, 274.62994, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(761.865, 320.56665, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(698.4779, 357.44815, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(368.96402, 307.96692, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(397.976, 191.30359, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(630.57086, 287.8582, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(681.5489, 249.64093, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(715.3935, 68.7173, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(694.1545, 133.57199, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(610.15204, 113.82064, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(630.8845, 20.689224, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(540.7711, 137.6132, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(537.66595, 22.484417, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(698.94464, -29.003809, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(484.63077, 240.16885, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(625.19434, -106.06828, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(471.503, -37.024597, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(371.08115, 20.902878, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(454.7123, 52.57748, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(296.75232, 199.64795, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(346.6972, 108.98679, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-248.76329, 249.0611, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-286.87378, 314.60876, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-367.6957, 329.33493, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-412.78134, 345.42844, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-442.7754, 375.74097, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-483.41983, 368.29626, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-459.85452, 414.75168, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-502.5123, 408.98383, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-565.10535, 478.27432, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-601.5274, 511.83945, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-944.24585, 691.12, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-931.35187, 589.1134, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-771.3383, 666.48676, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-677.6879, 622.9343, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-820.3416, 785.6165, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-763.34973, 1285.6703, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-688.8919, 1085.7676, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-693.6817, 1179.0905, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-914.90204, 851.2685, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-962.4303, 785.87506, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1007.714, 420.9937, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1048.2303, 489.6304, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1064.6812, 556.10266, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-823.8863, 559.6887, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1841.9147, 473.96136, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1228.6599, 655.82654, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1367.5376, 656.41113, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1292.3727, 614.74725, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1347.9618, 592.12866, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1415.6101, 611.245, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1425.4728, 688.354, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1601.2291, 632.0996, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1607.4061, 525.0739, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1891.9865, 602.4464, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1748.0155, 774.38257, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1756.3093, 441.1571, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1659.6664, 445.83948, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1715.9062, 513.1545, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1622.716, 753.8743, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1960.912, 553.3747, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1759.3241, 642.2764, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1996.7029, 665.4455, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1898.7565, 782.4315, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1890.2098, 858.5427, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1839.9963, 677.36755, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1834.5769, 785.1056, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1726.3583, 1006.7147, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1815.3987, 1035.2812, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1671.8082, 1051.5219, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1709.0289, 1176.0063, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1466.338, 1149.5061, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1626.4349, 1219.1504, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1369.0414, 1265.8625, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1609.1605, 1303.8091, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1761.8834, 1315.565, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1744.7252, 1264.2054, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1678.3536, 1316.0455, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1816.9945, 1381.3258, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1741.7339, 1378.1368, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1652.2417, 1368.1816, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1593.6675, 1391.6636, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1418.5059, 1375.0219, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1357.6576, 1137.4973, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1248.4183, 1237.4089, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1381.8152, 1484.4087, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1486.7922, 1254.3618, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1826.1975, 1325.8721, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1875.0951, 1358.8074, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1947.1533, 1356.342, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-2010.5521, 1355.1938, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-2109.6418, 1347.1094, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-2158.6187, 1337.4937, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-2404.0552, 1247.936, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-2294.421, 1312.6201, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-2553.9766, 1184.5541, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-2650.4707, 1203.0962, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-2789.5098, 1043.1688, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-2867.0732, 1130.4045, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-3086.3433, 996.8286, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-3245.0986, 826.1572, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-3068.1497, 890.41077, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-3349.6138, 973.85535, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-3380.0623, 835.0604, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-2991.7432, 823.3338, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-2969.5305, 1089.4701, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-2941.232, 953.50775, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-2806.57, 977.8125, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-2853.0745, 904.79266, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-3090.2327, 773.6434, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-3209.5874, 950.7618, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-2907.095, 733.8213, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-3160.334, 683.23254, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-3305.6797, 697.62836, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1547.7715, 47.127335, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1633.998, 72.332794, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1605.924, -64.57368, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1612.7029, 201.73431, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1760.5461, 133.74829, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1697.4783, -84.428185, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1653.0258, -200.12703, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1830.8038, -28.841492, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1508.8357, -93.8628, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1470.3339, 8.975389, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1382.806, -124.53481, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1451.0323, -191.13214, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1229.1382, -139.66505, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1273.5073, 255.23343, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1392.1522, 61.521183, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1471.1974, 219.67377, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1360.1738, 259.09476, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1273.1461, 120.22259, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1163.1133, 63.197227, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1112.6571, -67.51372, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1105.2427, 9.6751, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1170.1383, -73.7283, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1109.3888, -212.51418, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1070.5961, -132.7198, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1239.8583, -206.93228, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1167.38, -321.94727, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1355.152, -202.72914, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1257.1421, -294.17184, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1468.8673, -270.68317, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1414.2588, -375.38873, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1523.2799, -359.96863, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1367.8212, -291.29562, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1629.0082, -372.22333, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1721.6284, -359.6094, 25));

		// 'Repusbunny_Bow_Green' GenType 35 Spawn Points
		AddSpawnPoint("f_tableland_28_1.Id3", "f_tableland_28_1", Rectangle(-1383.2535, -129.48665, 25));
		AddSpawnPoint("f_tableland_28_1.Id3", "f_tableland_28_1", Rectangle(-1331.3939, 208.2179, 25));
		AddSpawnPoint("f_tableland_28_1.Id3", "f_tableland_28_1", Rectangle(-1164.5509, -9.234051, 25));
		AddSpawnPoint("f_tableland_28_1.Id3", "f_tableland_28_1", Rectangle(-1622.4304, -231.07948, 25));
		AddSpawnPoint("f_tableland_28_1.Id3", "f_tableland_28_1", Rectangle(-1666.1749, 141.77182, 25));
		AddSpawnPoint("f_tableland_28_1.Id3", "f_tableland_28_1", Rectangle(-1130.678, 394.33942, 25));
		AddSpawnPoint("f_tableland_28_1.Id3", "f_tableland_28_1", Rectangle(-2906.6462, 1064.8467, 25));
		AddSpawnPoint("f_tableland_28_1.Id3", "f_tableland_28_1", Rectangle(-2208.072, 1345.5255, 25));
		AddSpawnPoint("f_tableland_28_1.Id3", "f_tableland_28_1", Rectangle(-1764.7778, 990.31024, 25));
		AddSpawnPoint("f_tableland_28_1.Id3", "f_tableland_28_1", Rectangle(-867.4383, 637.9898, 25));
		AddSpawnPoint("f_tableland_28_1.Id3", "f_tableland_28_1", Rectangle(-1534.2758, 1249.3677, 25));
		AddSpawnPoint("f_tableland_28_1.Id3", "f_tableland_28_1", Rectangle(-1829.462, 779.4019, 25));
		AddSpawnPoint("f_tableland_28_1.Id3", "f_tableland_28_1", Rectangle(-1707.7677, 579.93665, 25));
		AddSpawnPoint("f_tableland_28_1.Id3", "f_tableland_28_1", Rectangle(-1344.1188, 711.3946, 25));
		AddSpawnPoint("f_tableland_28_1.Id3", "f_tableland_28_1", Rectangle(-851.1938, 837.8529, 25));
		AddSpawnPoint("f_tableland_28_1.Id3", "f_tableland_28_1", Rectangle(-1367.1448, 1426.221, 25));
		AddSpawnPoint("f_tableland_28_1.Id3", "f_tableland_28_1", Rectangle(-1779.3336, -6.9213676, 25));

		// 'Saltisdaughter_Mage_Red' GenType 39 Spawn Points
		AddSpawnPoint("f_tableland_28_1.Id4", "f_tableland_28_1", Rectangle(2163.7163, 328.27695, 25));
		AddSpawnPoint("f_tableland_28_1.Id4", "f_tableland_28_1", Rectangle(-126.30708, -520.05225, 25));
		AddSpawnPoint("f_tableland_28_1.Id4", "f_tableland_28_1", Rectangle(577.275, 28.748514, 25));
		AddSpawnPoint("f_tableland_28_1.Id4", "f_tableland_28_1", Rectangle(406.60297, 264.10382, 25));
		AddSpawnPoint("f_tableland_28_1.Id4", "f_tableland_28_1", Rectangle(745.263, 253.6511, 25));
		AddSpawnPoint("f_tableland_28_1.Id4", "f_tableland_28_1", Rectangle(1173.8237, -558.18744, 25));
		AddSpawnPoint("f_tableland_28_1.Id4", "f_tableland_28_1", Rectangle(1431.5873, -291.19574, 25));
		AddSpawnPoint("f_tableland_28_1.Id4", "f_tableland_28_1", Rectangle(1533.4487, -692.98584, 25));
		AddSpawnPoint("f_tableland_28_1.Id4", "f_tableland_28_1", Rectangle(1607.6062, -481.5982, 25));
		AddSpawnPoint("f_tableland_28_1.Id4", "f_tableland_28_1", Rectangle(2103.3564, -70.27001, 25));
		AddSpawnPoint("f_tableland_28_1.Id4", "f_tableland_28_1", Rectangle(1802.4371, 905.61053, 25));
		AddSpawnPoint("f_tableland_28_1.Id4", "f_tableland_28_1", Rectangle(-520.30664, 450.63974, 25));
		AddSpawnPoint("f_tableland_28_1.Id4", "f_tableland_28_1", Rectangle(-295.16144, 264.44507, 25));
		AddSpawnPoint("f_tableland_28_1.Id4", "f_tableland_28_1", Rectangle(170.63567, 256.92734, 25));
		AddSpawnPoint("f_tableland_28_1.Id4", "f_tableland_28_1", Rectangle(2.0256157, -641.7832, 25));
		AddSpawnPoint("f_tableland_28_1.Id4", "f_tableland_28_1", Rectangle(1407.174, -546.8157, 25));
		AddSpawnPoint("f_tableland_28_1.Id4", "f_tableland_28_1", Rectangle(1822.2477, -176.13992, 25));
		AddSpawnPoint("f_tableland_28_1.Id4", "f_tableland_28_1", Rectangle(1739.2124, 737.2787, 25));
	}
}
