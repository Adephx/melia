//--- Melia Script -----------------------------------------------------------
// f_remains_37
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Stele Road' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FRemains37MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners ---------------------------------

		AddSpawner("f_remains_37.Id1", MonsterId.Stub_Tree, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_remains_37.Id2", MonsterId.Stub_Tree, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_remains_37.Id3", MonsterId.Tama, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_remains_37.Id4", MonsterId.TreeAmbulo, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_remains_37.Id5", MonsterId.TreeAmbulo, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_remains_37.Id6", MonsterId.Tama, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_remains_37.Id7", MonsterId.TreeAmbulo, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_remains_37.Id8", MonsterId.Rootcrystal_01, 4, 5, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Stub_Tree' GenType 4 Spawn Points
		AddSpawnPoint("f_remains_37.Id1", "f_remains_37", Rectangle(1428.37, 354.42, 25));
		AddSpawnPoint("f_remains_37.Id1", "f_remains_37", Rectangle(1470.9, 721.23, 25));
		AddSpawnPoint("f_remains_37.Id1", "f_remains_37", Rectangle(1384.8374, 241.92755, 25));
		AddSpawnPoint("f_remains_37.Id1", "f_remains_37", Rectangle(1236.6007, 389.50888, 25));
		AddSpawnPoint("f_remains_37.Id1", "f_remains_37", Rectangle(1270.1338, 598.53766, 25));
		AddSpawnPoint("f_remains_37.Id1", "f_remains_37", Rectangle(1311.5668, 708.72546, 25));
		AddSpawnPoint("f_remains_37.Id1", "f_remains_37", Rectangle(1609.2543, 640.27496, 25));
		AddSpawnPoint("f_remains_37.Id1", "f_remains_37", Rectangle(1569.8679, 444.7861, 25));
		AddSpawnPoint("f_remains_37.Id1", "f_remains_37", Rectangle(1545.7762, 291.7795, 25));
		AddSpawnPoint("f_remains_37.Id1", "f_remains_37", Rectangle(1446.1232, 544.38586, 25));

		// 'Stub_Tree' GenType 5 Spawn Points
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-735.4481, -2267.1948, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(1241.22, -2312.29, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-973.86334, -2347.6135, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-821.4105, -2455.5615, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-512.27435, -2372.1711, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-946.1378, -2141.5068, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-800.4233, -2045.6123, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-659.1449, -2470.0322, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-429.90762, -2170.4019, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-362.2725, -2323.6086, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-1128.476, -2165.8774, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-1364.3009, -2181.9402, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-608.58624, -2110.4414, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(1283.4263, -2190.4966, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(1078.6702, -2264.619, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(1179.2397, -2415.527, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(1311.5815, -2528.282, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(1415.6884, -2338.7852, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(1408.0282, -2242.2915, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(1377.3276, -2455.0256, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(1330.7148, -2331.7576, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(1195.2242, -2197.4434, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-711.36957, -2169.1487, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-796.42975, -2327.8213, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(154.35637, -2271.5813, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(207.56532, -2227.7585, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(794.84033, -2242.105, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(877.3782, -2215.87, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(1378.1349, -2393.2131, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(1446.2343, -2452.8025, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(1489.5911, -2364.0037, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(1477.4126, -2256.4824, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(1341.5304, -2280.4868, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(1217.9624, -2244.4834, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(1266.7083, -2386.8901, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(1286.7894, -2505.8254, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(1307.198, -2431.234, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(1374.524, -2509.2825, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(1166.3671, -2339.2734, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(1149.1627, -2261.6455, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(1274.3053, -2264.7212, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(1072.6099, -2362.0872, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(1235.7928, -2444.73, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(1007.426, -2274.4446, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(1086.942, -2208.7126, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(1107.8755, -2310.8215, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(1330.6116, -2206.6929, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(1001.4824, -2211.1362, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(874.78613, -2268.3652, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(830.75214, -2278.207, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(837.17145, -2212.8767, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(774.7322, -2283.4236, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(758.04156, -2210.439, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(217.93777, -2292.8757, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(153.3327, -2216.6765, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(241.97742, -2254.9875, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-321.46014, -2257.1465, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-386.50882, -2153.6538, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-386.4625, -2265.905, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-308.3639, -2204.6396, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-381.53802, -2201.0117, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-505.8048, -2178.1182, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-642.06287, -2288.2693, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-811.30255, -2229.1694, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-738.2301, -2054.524, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-628.2929, -2045.7432, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-673.488, -2153.5894, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-598.5147, -2245.195, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-553.69446, -2198.2295, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-569.2849, -2126.3855, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-713.63513, -2300.142, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-431.12073, -2382.1545, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-489.445, -2427.7925, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-587.08075, -2488.0044, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-673.8926, -2537.3994, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-581.24506, -2424.1907, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-673.3829, -2356.7417, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-872.64355, -2395.0256, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-771.87616, -2383.3274, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-667.6547, -2227.801, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-813.5718, -2136.6628, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-629.0912, -2185.1326, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-870.6371, -2066.1753, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-981.2721, -2064.6604, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-895.79333, -2159.2148, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-923.7068, -2298.213, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-859.8337, -2285.734, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-882.48334, -2199.619, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-979.4225, -2236.912, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-1037.5795, -2154.1274, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-1032.9202, -2066.2712, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-1088.1033, -2211.293, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-930.2583, -2060.577, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-770.48065, -2114.0725, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-684.0565, -2067.2937, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-837.6432, -2002.8038, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-745.36945, -1984.2375, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-772.4913, -2188.9106, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-1317.6658, -2223.4563, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-1303.0763, -2119.8494, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-1427.9363, -2243.961, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-1371.5, -2124.6213, 20));
		AddSpawnPoint("f_remains_37.Id2", "f_remains_37", Rectangle(-1291.6139, -2163.0486, 20));

		// 'Tama' GenType 9 Spawn Points
		AddSpawnPoint("f_remains_37.Id3", "f_remains_37", Rectangle(1458.39, 583.66, 9999));

		// 'TreeAmbulo' GenType 37 Spawn Points
		AddSpawnPoint("f_remains_37.Id4", "f_remains_37", Rectangle(479.13, 643.95, 9999));

		// 'TreeAmbulo' GenType 47 Spawn Points
		AddSpawnPoint("f_remains_37.Id5", "f_remains_37", Rectangle(593.3, -853.48, 100));
		AddSpawnPoint("f_remains_37.Id5", "f_remains_37", Rectangle(789.16, -871.64, 100));
		AddSpawnPoint("f_remains_37.Id5", "f_remains_37", Rectangle(795.6783, -1160.8387, 100));
		AddSpawnPoint("f_remains_37.Id5", "f_remains_37", Rectangle(729.34125, -1246.5375, 100));
		AddSpawnPoint("f_remains_37.Id5", "f_remains_37", Rectangle(558.29, -1380.89, 100));
		AddSpawnPoint("f_remains_37.Id5", "f_remains_37", Rectangle(370.36, -1243.86, 100));
		AddSpawnPoint("f_remains_37.Id5", "f_remains_37", Rectangle(396.92, -964.78, 100));
		AddSpawnPoint("f_remains_37.Id5", "f_remains_37", Rectangle(384.55133, -1101.5079, 100));
		AddSpawnPoint("f_remains_37.Id5", "f_remains_37", Rectangle(570.6017, -964.1415, 100));
		AddSpawnPoint("f_remains_37.Id5", "f_remains_37", Rectangle(430.46027, -1333.8362, 100));
		AddSpawnPoint("f_remains_37.Id5", "f_remains_37", Rectangle(657.1856, -1291.0573, 100));
		AddSpawnPoint("f_remains_37.Id5", "f_remains_37", Rectangle(723.0592, -1118.161, 100));
		AddSpawnPoint("f_remains_37.Id5", "f_remains_37", Rectangle(740.4951, -1012.528, 100));
		AddSpawnPoint("f_remains_37.Id5", "f_remains_37", Rectangle(699.7334, -837.3079, 100));
		AddSpawnPoint("f_remains_37.Id5", "f_remains_37", Rectangle(509.20193, -880.3176, 100));

		// 'Tama' GenType 48 Spawn Points
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(591.21, 664.45, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(1400.48, 613.35, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(602.36, 2777.87, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(369.5293, 2639.319, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(365.7393, 2797.0854, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(676.99005, 2574.9844, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(506.56662, 2680.5928, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(633.7839, 2896.2812, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(822.83, 2770.017, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(803.605, 2641.6863, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(884.73926, 2486.9155, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(816.211, 2962.5986, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(971.9517, 2695.397, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(187.23448, 2457.063, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(328.19284, 2454.233, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(361.7766, 727.1234, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(524.9018, 791.12933, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(429.74, 591.13983, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(512.9215, 425.25806, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(670.2561, 497.06958, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(784.137, 588.0366, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(652.25134, 651.7298, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(554.05536, 729.0632, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(458.47778, 774.1467, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(465.59808, 847.37494, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(366.95657, 889.86383, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(294.8559, 819.36285, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(279.78708, 738.684, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(350.96802, 825.8053, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(392.95358, 770.46844, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(399.79645, 669.4986, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(483.34906, 706.2381, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(359.61932, 680.85406, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(527.52716, 574.6257, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(561.324, 645.37195, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(653.1212, 558.1774, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(700.4306, 600.68774, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(702.2238, 672.58575, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(729.4713, 554.05725, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(717.73004, 490.87885, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(790.2444, 493.3747, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(761.94604, 404.0946, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(687.44324, 382.09833, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(636.7539, 368.75433, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(604.21747, 392.03485, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(609.7963, 490.092, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(550.73206, 494.3279, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(587.3075, 573.19403, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(474.93576, 483.6373, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(417.54242, 427.17096, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(362.33347, 514.4567, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(330.67697, 566.4219, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(324.5783, 644.4529, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(373.96725, 607.15717, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(415.02597, 517.9785, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(490.44693, 556.7377, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(554.23346, 403.23865, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(819.22565, 539.6028, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(1221.835, 633.0332, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(1539.2128, 785.8865, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(1537.2047, 824.5924, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(1630.3872, 826.7339, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(1700.922, 722.8004, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(1777.1969, 781.40594, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(1699.5995, 807.49133, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(1745.4078, 630.6174, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(1680.6992, 532.7694, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(1668.3029, 429.95978, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(1623.6072, 290.3493, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(1572.2042, 208.88373, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(1484.2423, 143.79266, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(1534.9694, 113.87109, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(1463.5934, 277.98462, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(1416.3428, 167.63976, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(1291.6045, 197.09656, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(1296.051, 366.49265, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(1366.3284, 335.06345, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(1353.4332, 472.54364, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(1499.1672, 485.30197, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(1488.4156, 375.2425, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(1614.4784, 385.9959, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(1435.3433, 423.1683, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(1273.0873, 484.08252, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(1160.2749, 482.95486, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(1167.8245, 610.6289, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(1155.7272, 711.8942, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(1231.4594, 692.029, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(1331.0284, 580.89105, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(1363.8309, 721.3191, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(1378.4456, 820.52576, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(1442.4315, 854.96936, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(1437.3529, 787.046, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(1540.5856, 695.8104, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(1599.2167, 727.1944, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(1656.3519, 607.2606, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(1689.4297, 655.447, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(1537.5322, 586.84265, 30));
		AddSpawnPoint("f_remains_37.Id6", "f_remains_37", Rectangle(1595.7177, 548.845, 30));

		// 'TreeAmbulo' GenType 59 Spawn Points
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(508.83, 2767.66, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(354.4175, 2697.9082, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(888.4559, 2584.292, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(563.3172, 2918.0327, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(734.93317, 2905.156, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(769.06177, 2741.3237, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(765.8938, 2568.8958, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(459.41208, 2545.1042, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(197.42484, 2481.7957, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(615.2316, 2606.5264, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(921.48254, 2715.7766, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(937.42456, 2775.6033, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(891.4866, 2864.8145, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(767.6863, 2884.321, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(932.30664, 2850.889, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(864.188, 2802.7263, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(862.4405, 2699.2969, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(952.644, 2615.2273, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(925.58966, 2532.728, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(804.2388, 2475.3433, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(828.6806, 2550.5774, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(878.405, 2647.9631, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(717.24023, 2640.7375, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(676.7471, 2725.4556, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(772.8252, 2696.9268, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(683.4948, 2814.762, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(766.96625, 2840.8945, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(722.45087, 2777.7754, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(825.18463, 2895.884, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(667.1642, 2945.1858, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(599.8343, 2826.904, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(596.4203, 2711.3635, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(545.78253, 2577.909, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(572.0124, 2537.1902, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(460.04184, 2608.4375, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(432.50046, 2723.6035, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(448.4717, 2845.5125, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(478.49435, 2930.4565, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(538.2483, 2869.0225, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(372.87094, 2905.8237, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(290.23068, 2738.3274, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(395.3086, 2584.928, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(300.1602, 2535.1558, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(268.61984, 2607.3225, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(222.90237, 2699.6653, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(363.4942, 2528.4128, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(784.15955, -939.48486, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(690.6387, -932.1285, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(617.289, -984.04614, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(449.66333, -976.0829, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(408.44287, -879.3917, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(569.9149, -902.87164, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(546.83014, -1133.4448, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(625.466, -1187.7964, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(615.58234, -1300.3743, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(624.5188, -1051.877, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(817.12317, -981.70044, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(865.77673, -885.5794, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(864.24146, -1061.0154, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(779.70496, -1090.1294, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(820.11523, -1043.6036, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(779.8708, -1235.4021, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(865.4885, -1181.4807, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(642.02673, -1372.8789, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(729.0588, -1336.0065, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(518.1161, -1319.0763, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(463.69284, -1200.8015, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(556.14606, -1231.1691, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(469.6913, -1088.669, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(526.8364, -1027.1224, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(656.75134, -1108.9867, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(499.24762, -937.5459, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(422.23743, -1131.3635, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(354.01083, -923.429, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(631.16943, -806.3575, 30));
		AddSpawnPoint("f_remains_37.Id7", "f_remains_37", Rectangle(496.85156, -1387.6447, 30));

		// 'Rootcrystal_01' GenType 60 Spawn Points
		AddSpawnPoint("f_remains_37.Id8", "f_remains_37", Rectangle(-1574.72, -2501.38, 250));
		AddSpawnPoint("f_remains_37.Id8", "f_remains_37", Rectangle(-1359.04, -2188.67, 250));
		AddSpawnPoint("f_remains_37.Id8", "f_remains_37", Rectangle(-854.71, -2172.89, 250));
		AddSpawnPoint("f_remains_37.Id8", "f_remains_37", Rectangle(-526.15, -2244.89, 250));
		AddSpawnPoint("f_remains_37.Id8", "f_remains_37", Rectangle(105.92, -2278.57, 250));
		AddSpawnPoint("f_remains_37.Id8", "f_remains_37", Rectangle(616.99, -2221.74, 250));
		AddSpawnPoint("f_remains_37.Id8", "f_remains_37", Rectangle(1064.27, -2241.75, 250));
		AddSpawnPoint("f_remains_37.Id8", "f_remains_37", Rectangle(1380.69, -2374.23, 250));
		AddSpawnPoint("f_remains_37.Id8", "f_remains_37", Rectangle(568.44, -1295.3, 250));
		AddSpawnPoint("f_remains_37.Id8", "f_remains_37", Rectangle(601.31, -891.01, 250));
		AddSpawnPoint("f_remains_37.Id8", "f_remains_37", Rectangle(815.25, -1062.92, 250));
		AddSpawnPoint("f_remains_37.Id8", "f_remains_37", Rectangle(530.81, -336.72, 250));
		AddSpawnPoint("f_remains_37.Id8", "f_remains_37", Rectangle(600.39, 478.24, 250));
		AddSpawnPoint("f_remains_37.Id8", "f_remains_37", Rectangle(376.36, 740.95, 250));
		AddSpawnPoint("f_remains_37.Id8", "f_remains_37", Rectangle(1164.3, 537.5, 250));
		AddSpawnPoint("f_remains_37.Id8", "f_remains_37", Rectangle(1472.76, 807.06, 250));
		AddSpawnPoint("f_remains_37.Id8", "f_remains_37", Rectangle(1562.53, 291.84, 250));
		AddSpawnPoint("f_remains_37.Id8", "f_remains_37", Rectangle(401.79, 1130.97, 250));
		AddSpawnPoint("f_remains_37.Id8", "f_remains_37", Rectangle(98.87, 1772.28, 250));
		AddSpawnPoint("f_remains_37.Id8", "f_remains_37", Rectangle(536.97, 1593.7, 250));
		AddSpawnPoint("f_remains_37.Id8", "f_remains_37", Rectangle(118.55, 2274.11, 250));
		AddSpawnPoint("f_remains_37.Id8", "f_remains_37", Rectangle(393.65, 2670.2, 250));
		AddSpawnPoint("f_remains_37.Id8", "f_remains_37", Rectangle(779.96, 2771.45, 250));
		AddSpawnPoint("f_remains_37.Id8", "f_remains_37", Rectangle(693.82, 2559.45, 250));
	}
}
