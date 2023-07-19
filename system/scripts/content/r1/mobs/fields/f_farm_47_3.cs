//--- Melia Script -----------------------------------------------------------
// f_farm_47_3
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Myrkiti Farm' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FFarm473MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_farm_47_3", MonsterId.Kepo_Seed_Violet, Properties("MHP", 173265, "MINPATK", 2729, "MAXPATK", 3256, "MINMATK", 2729, "MAXMATK", 3256, "DEF", 4896, "MDEF", 4896));
		AddPropertyOverrides("f_farm_47_3", MonsterId.Cronewt_Bow, Properties("MHP", 174066, "MINPATK", 2740, "MAXPATK", 3269, "MINMATK", 2740, "MAXMATK", 3269, "DEF", 4969, "MDEF", 4969));
		AddPropertyOverrides("f_farm_47_3", MonsterId.Operor_White, Properties("MHP", 174919, "MINPATK", 2751, "MAXPATK", 3282, "MINMATK", 2751, "MAXMATK", 3282, "DEF", 5047, "MDEF", 5047));
		AddPropertyOverrides("f_farm_47_3", MonsterId.Ellom_Violet, Properties("MHP", 175820, "MINPATK", 2762, "MAXPATK", 3296, "MINMATK", 2762, "MAXMATK", 3296, "DEF", 5129, "MDEF", 5129));

		// Monster Spawners ---------------------------------

		AddSpawner("f_farm_47_3.Id1", MonsterId.Kepo_Seed_Violet, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_farm_47_3.Id2", MonsterId.Ellom_Violet, 60, 80, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_farm_47_3.Id3", MonsterId.Kepo_Seed_Violet, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_farm_47_3.Id4", MonsterId.Rootcrystal_01, 23, 30, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_farm_47_3.Id5", MonsterId.Cronewt_Bow, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_farm_47_3.Id6", MonsterId.Operor_White, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Kepo_Seed_Violet' GenType 3 Spawn Points
		AddSpawnPoint("f_farm_47_3.Id1", "f_farm_47_3", Rectangle(-605.3078, -402.17957, 25));
		AddSpawnPoint("f_farm_47_3.Id1", "f_farm_47_3", Rectangle(-626.2746, -275.81403, 25));
		AddSpawnPoint("f_farm_47_3.Id1", "f_farm_47_3", Rectangle(-694.27716, -399.42264, 25));
		AddSpawnPoint("f_farm_47_3.Id1", "f_farm_47_3", Rectangle(-1328.6486, -476.4355, 25));
		AddSpawnPoint("f_farm_47_3.Id1", "f_farm_47_3", Rectangle(-1264.5095, -326.2114, 25));
		AddSpawnPoint("f_farm_47_3.Id1", "f_farm_47_3", Rectangle(-1114.3954, -406.48267, 25));
		AddSpawnPoint("f_farm_47_3.Id1", "f_farm_47_3", Rectangle(-1187.7015, -365.07343, 25));
		AddSpawnPoint("f_farm_47_3.Id1", "f_farm_47_3", Rectangle(-253.24759, -824.45044, 25));
		AddSpawnPoint("f_farm_47_3.Id1", "f_farm_47_3", Rectangle(-13.274094, -589.4372, 25));
		AddSpawnPoint("f_farm_47_3.Id1", "f_farm_47_3", Rectangle(-258.60144, -610.76013, 25));
		AddSpawnPoint("f_farm_47_3.Id1", "f_farm_47_3", Rectangle(-150.61404, -713.08014, 25));
		AddSpawnPoint("f_farm_47_3.Id1", "f_farm_47_3", Rectangle(-1084.5859, -279.07452, 25));
		AddSpawnPoint("f_farm_47_3.Id1", "f_farm_47_3", Rectangle(-466.30966, -330.84134, 25));
		AddSpawnPoint("f_farm_47_3.Id1", "f_farm_47_3", Rectangle(-627.44507, 1.8970942, 25));
		AddSpawnPoint("f_farm_47_3.Id1", "f_farm_47_3", Rectangle(-590.07477, 167.81839, 25));
		AddSpawnPoint("f_farm_47_3.Id1", "f_farm_47_3", Rectangle(-491.90347, 38.551743, 25));
		AddSpawnPoint("f_farm_47_3.Id1", "f_farm_47_3", Rectangle(-193.87659, 52.083996, 25));
		AddSpawnPoint("f_farm_47_3.Id1", "f_farm_47_3", Rectangle(-145.85387, 105.25234, 25));
		AddSpawnPoint("f_farm_47_3.Id1", "f_farm_47_3", Rectangle(-12.23999, -27.011797, 25));
		AddSpawnPoint("f_farm_47_3.Id1", "f_farm_47_3", Rectangle(-86.23916, -59.764484, 25));
		AddSpawnPoint("f_farm_47_3.Id1", "f_farm_47_3", Rectangle(-77.874374, 18.82851, 25));
		AddSpawnPoint("f_farm_47_3.Id1", "f_farm_47_3", Rectangle(-1293.2463, -395.75806, 25));

		// 'Ellom_Violet' GenType 4 Spawn Points
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-630.5358, -278.6277, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-608.1281, -493.44125, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-88.38387, 144.79605, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-610.0394, 34.30896, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-830.23004, 514.0014, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-614.99506, 909.0321, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1203.6075, 576.3915, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1748.482, 72.01906, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1207.044, -410.04355, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-803.3211, -389.91068, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-82.889854, -611.8036, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-447.28076, 909.21436, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-153.23596, -28.795746, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-47.827408, -739.15955, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-259.94724, -705.6113, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-193.5865, -546.30804, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-123.01626, -824.6481, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1236.5286, 411.207, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-6.2813234, 95.8858, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-648.4653, 135.43192, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1844.3921, -20.471527, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1409.3359, 663.1898, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1599.8701, 802.2448, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1356.8257, 844.90424, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-2033.9053, 776.1505, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-2161.1755, 772.0756, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1306.377, 458.3112, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1985.5492, 905.7273, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-2107.5713, 860.0061, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1511.8047, 702.9855, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1423.7885, 753.8976, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1354.2544, 680.8183, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1175.9548, 509.82904, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-555.1664, 820.4514, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-412.51178, 840.83026, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-477.13477, 731.96875, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-777.8457, -309.64908, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-660.8847, -354.18356, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-546.609, -292.01804, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1278.4652, -241.61905, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1378.9365, -423.20865, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1018.5196, -336.31055, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-936.98285, -371.03976, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1168.2433, -225.77222, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1896.8201, -178.05824, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1736.8805, -281.18686, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1599.9913, -182.3218, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1569.3684, 19.780773, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1645.7947, 71.577805, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1711.2258, -127.63134, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-2139.9585, 816.0994, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-2216.104, 806.1331, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-2189.7588, 773.97156, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-2195.906, 838.1284, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-2176.7544, 828.5672, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-2216.4805, 882.0984, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-2179.4868, 918.69965, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-2154.6887, 940.96094, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-2207.9666, 727.1669, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-2234.5276, 766.892, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-2171.0085, 717.76215, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-2144.9202, 750.5394, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-2121.335, 726.13544, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-2089.1748, 699.6289, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-2078.6555, 758.92096, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-2003.9391, 741.2553, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1984.9724, 802.71545, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-2024.2826, 821.0101, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1569.5977, 837.3467, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1530.2139, 844.70355, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1541.4705, 810.0324, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1494.5923, 813.7183, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1422.8906, 832.17694, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1388.1146, 847.4084, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1354.0415, 809.8874, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1598.9369, 749.24506, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1559.1334, 769.9023, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1520.9146, 739.6691, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1483.2401, 757.13574, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1460.224, 791.10614, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1450.4993, 735.5862, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1483.1694, 724.2018, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1424.7883, 713.9321, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1383.4355, 765.3575, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1442.2808, 766.98096, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1597.7826, 771.5022, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1604.3202, 822.97845, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1834.404, 15.952148, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1794.6691, 23.484268, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1609.4202, 14.533508, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1557.832, -17.153145, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1622.0463, -19.595964, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1553.1763, -50.101494, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1558.2756, -97.841385, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1610.6763, -100.57358, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1572.1285, -143.05304, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1622.4406, -153.95949, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1601.9336, -128.07718, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1645.031, -85.33408, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1664.5148, -52.05224, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1806.2947, -58.252926, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1865.6942, -57.803547, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1884.3348, -15.736494, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1899.8883, -84.43813, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1883.6049, -133.30899, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1903.0145, -120.77476, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1862.5096, -160.50006, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1867.4644, -201.02725, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1836.7466, -231.56, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1799.9734, -99.58735, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1752.8947, -139.90958, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1743.1161, -106.02798, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1709.9427, -162.24727, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1751.2999, -231.39413, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1720.1697, -258.49747, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1771.5178, -271.293, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1718.338, -306.27643, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1373.9209, -496.07816, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1409.382, -431.7585, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1430.4714, -391.78238, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1379.4943, -332.98636, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1253.2504, -344.84903, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1127.9886, -298.60202, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1317.2522, -384.71704, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1170.9717, -344.80643, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1312.1248, -487.5476, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1206.2838, -517.8798, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1265.5876, -447.02634, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1130.2023, -472.17584, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1100.2677, -428.1738, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1054.3893, -413.0129, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1098.6105, -380.14545, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1058.4844, -358.81516, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1010.0596, -376.95078, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1026.3093, -288.47122, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-975.9938, -334.372, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-964.33594, -369.08942, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1052.668, -326.88678, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-817.91644, -430.80753, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-783.9802, -473.29706, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-736.1223, -455.8335, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-733.8157, -489.54498, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-654.65765, -410.27924, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-720.5853, -426.3525, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-750.828, -422.31232, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-771.03375, -374.695, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-700.4579, -373.31732, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-636.34344, -362.78598, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-640.4954, -317.97922, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-674.9127, -257.73727, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-644.132, -233.49164, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-583.82513, -239.34541, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-534.6093, -245.16165, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-570.6513, -304.48846, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-588.26825, -342.13028, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-562.8554, -422.79684, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-542.9994, -477.34006, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-380.46805, -595.3499, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-337.83154, -569.8115, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-292.2601, -543.5769, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-234.98743, -526.4744, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-343.85898, -656.15234, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-395.67618, -694.01587, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-411.74707, -655.41113, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-406.42566, -742.8709, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-354.65164, -727.7684, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-197.98596, -777.84534, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-354.85028, -823.32947, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-307.5958, -843.3856, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-303.8958, -791.49524, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-261.92682, -865.4484, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-236.32123, -650.4865, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(49.93942, -663.07874, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-59.5255, -541.9205, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-174.41864, -702.91016, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(32.319588, -591.0715, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-166.17216, -869.0833, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-75.99985, -808.5772, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-12.847948, -769.08484, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-20.894238, -705.0684, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1310.2422, 490.0777, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1300.3827, 521.0463, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1256.5453, 517.752, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1242.3339, 578.77576, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1152.6547, 571.20087, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1201.1024, 535.7007, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1119.2837, 474.94678, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1180.1428, 440.73212, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1204.0958, 465.6216, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1260.953, 432.89563, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1306.5378, 405.3591, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1259.5045, 460.01865, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1225.8132, 387.84717, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1124.3109, 428.31296, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-1153.1091, 474.1194, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-399.20895, 793.2455, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-416.70212, 753.49805, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-437.73984, 719.94073, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-462.38196, 753.29767, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-481.40176, 821.31854, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-496.24994, 769.0265, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-543.01776, 751.5943, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-526.62946, 786.8295, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-530.58594, 838.0787, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-516.3621, 903.66235, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-559.9476, 895.7396, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-611.35284, 856.20514, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-576.033, 843.8508, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-634.7794, 885.45306, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-671.3645, 853.16736, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-638.02637, 829.0529, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-664.92395, 797.6433, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-632.1523, 784.3923, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-610.7037, 714.2106, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-785.31525, 511.85382, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-813.82947, 547.5054, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-844.5145, 572.4854, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-857.7383, 507.19833, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-844.9698, 466.46234, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-801.4642, 457.0587, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-838.00977, 419.9095, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-877.9853, 469.48984, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-898.67096, 515.12946, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-917.9498, 534.45325, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-859.3114, 382.38004, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-813.4517, 384.52173, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-812.68134, 439.87662, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-880.1408, 142.84862, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-620.18097, 119.53587, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-630.98755, 169.94582, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-554.45905, 143.14055, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-511.2341, 163.89377, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-474.74036, 126.83547, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-510.94324, 96.57677, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-554.2157, 61.62458, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-529.99207, -18.60886, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-489.87482, -34.56821, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-554.2471, -63.1284, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-631.27264, -36.263638, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-674.63544, -39.8525, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-519.8557, -59.465057, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-516.7267, 15.772058, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-442.0053, 1.7382984, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-405.8404, 25.05431, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-443.1756, 44.67107, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-427.33032, 75.099335, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-468.63895, 80.54348, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-502.34637, 121.94125, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-474.66748, 166.88269, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-646.0361, 49.416016, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-681.33826, 34.998154, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-714.8797, 14.970945, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-735.3433, 50.21514, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-702.8844, 74.66309, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-679.94495, 65.331856, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-725.0162, 88.05954, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-229.1711, 70.79685, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-200.59683, 101.40766, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(52.959366, 85.93823, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(31.0963, 7.347638, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-75.85508, 69.91412, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-66.02669, 109.43613, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-117.77178, 77.304405, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-229.82451, 26.082376, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-188.16129, -0.9537201, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-182.31393, -46.52996, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-135.41551, -81.12242, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-114.94807, -20.586697, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-58.85933, -27.547417, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-41.992542, 41.51218, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(17.904757, 65.74365, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(-14.807311, 142.35913, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(274.039, 174.63913, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(238.80313, 123.87674, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(307.27597, -15.438219, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(361.09198, -57.214207, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(344.8414, -23.981709, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(421.85614, -50.119537, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(360.70322, 111.13486, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(345.7781, 148.09747, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(479.66116, 126.72836, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(431.96948, 102.08984, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(406.6159, 153.24136, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(374.59695, 215.5475, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(311.45532, 224.4726, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(345.40607, 290.42523, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(389.8628, 304.089, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(431.22345, 268.50626, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(448.1863, 239.8168, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(418.43655, 198.34143, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(623.5487, 164.80284, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(567.10834, 169.35048, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(623.82574, 219.12782, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(666.11176, 206.12292, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(660.2244, 115.7809, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(633.1828, 69.802795, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(723.97064, 66.75553, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(781.41583, 119.30852, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(798.6398, 47.710968, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(765.5904, -13.872448, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(671.5279, 66.39409, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(603.39386, 123.41281, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(553.4212, 85.07472, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(588.732, 37.96253, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(553.67267, 5.0637584, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(578.10004, -49.51531, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(556.7848, -100.78635, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(615.78485, -113.74046, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(598.2978, 69.53578, 25));
		AddSpawnPoint("f_farm_47_3.Id2", "f_farm_47_3", Rectangle(415.10266, 28.447977, 25));

		// 'Kepo_Seed_Violet' GenType 33 Spawn Points
		AddSpawnPoint("f_farm_47_3.Id3", "f_farm_47_3", Rectangle(-695.9956, -468.01025, 9999));

		// 'Rootcrystal_01' GenType 35 Spawn Points
		AddSpawnPoint("f_farm_47_3.Id4", "f_farm_47_3", Rectangle(810.8327, 73.90259, 10));
		AddSpawnPoint("f_farm_47_3.Id4", "f_farm_47_3", Rectangle(493.3144, 173.71927, 10));
		AddSpawnPoint("f_farm_47_3.Id4", "f_farm_47_3", Rectangle(241.49084, 46.7063, 10));
		AddSpawnPoint("f_farm_47_3.Id4", "f_farm_47_3", Rectangle(-93.07601, 114.32398, 10));
		AddSpawnPoint("f_farm_47_3.Id4", "f_farm_47_3", Rectangle(-675.9219, 69.27896, 10));
		AddSpawnPoint("f_farm_47_3.Id4", "f_farm_47_3", Rectangle(-830.1036, 517.3009, 10));
		AddSpawnPoint("f_farm_47_3.Id4", "f_farm_47_3", Rectangle(-688.47894, 835.38074, 10));
		AddSpawnPoint("f_farm_47_3.Id4", "f_farm_47_3", Rectangle(-1156.9424, 572.68134, 10));
		AddSpawnPoint("f_farm_47_3.Id4", "f_farm_47_3", Rectangle(-1478.3544, 802.75684, 10));
		AddSpawnPoint("f_farm_47_3.Id4", "f_farm_47_3", Rectangle(-2058.9272, 930.15576, 10));
		AddSpawnPoint("f_farm_47_3.Id4", "f_farm_47_3", Rectangle(-2209.8362, 794.8866, 10));
		AddSpawnPoint("f_farm_47_3.Id4", "f_farm_47_3", Rectangle(-1768.5907, 421.9043, 10));
		AddSpawnPoint("f_farm_47_3.Id4", "f_farm_47_3", Rectangle(-1744.0276, -52.929424, 10));
		AddSpawnPoint("f_farm_47_3.Id4", "f_farm_47_3", Rectangle(-1713.3312, -308.4299, 10));
		AddSpawnPoint("f_farm_47_3.Id4", "f_farm_47_3", Rectangle(-1356.944, -394.63538, 10));
		AddSpawnPoint("f_farm_47_3.Id4", "f_farm_47_3", Rectangle(-991.8088, -338.94675, 10));
		AddSpawnPoint("f_farm_47_3.Id4", "f_farm_47_3", Rectangle(-612.1339, -526.2843, 10));
		AddSpawnPoint("f_farm_47_3.Id4", "f_farm_47_3", Rectangle(-401.6646, -723.6674, 10));
		AddSpawnPoint("f_farm_47_3.Id4", "f_farm_47_3", Rectangle(-15.943649, -749.42175, 10));
		AddSpawnPoint("f_farm_47_3.Id4", "f_farm_47_3", Rectangle(-1674.0637, -520.6646, 10));
		AddSpawnPoint("f_farm_47_3.Id4", "f_farm_47_3", Rectangle(-1654.335, -720.6824, 10));
		AddSpawnPoint("f_farm_47_3.Id4", "f_farm_47_3", Rectangle(-1420.0793, 463.8627, 10));
		AddSpawnPoint("f_farm_47_3.Id4", "f_farm_47_3", Rectangle(-1181.9048, -300.88467, 10));
		AddSpawnPoint("f_farm_47_3.Id4", "f_farm_47_3", Rectangle(-1851.9977, 287.37064, 10));

		// 'Cronewt_Bow' GenType 37 Spawn Points
		AddSpawnPoint("f_farm_47_3.Id5", "f_farm_47_3", Rectangle(-559.5475, -372.07123, 30));
		AddSpawnPoint("f_farm_47_3.Id5", "f_farm_47_3", Rectangle(-1734.1252, -200.34853, 30));
		AddSpawnPoint("f_farm_47_3.Id5", "f_farm_47_3", Rectangle(-1615.7578, -52.98912, 30));
		AddSpawnPoint("f_farm_47_3.Id5", "f_farm_47_3", Rectangle(-1736.5289, 0.7005687, 30));
		AddSpawnPoint("f_farm_47_3.Id5", "f_farm_47_3", Rectangle(-1861.1672, -86.81296, 30));
		AddSpawnPoint("f_farm_47_3.Id5", "f_farm_47_3", Rectangle(-1207.8734, -301.65674, 30));
		AddSpawnPoint("f_farm_47_3.Id5", "f_farm_47_3", Rectangle(-1162.2739, -431.63943, 30));
		AddSpawnPoint("f_farm_47_3.Id5", "f_farm_47_3", Rectangle(-713.2698, -308.42776, 30));
		AddSpawnPoint("f_farm_47_3.Id5", "f_farm_47_3", Rectangle(-376.95013, -637.9059, 30));
		AddSpawnPoint("f_farm_47_3.Id5", "f_farm_47_3", Rectangle(-84.03573, -652.3182, 30));
		AddSpawnPoint("f_farm_47_3.Id5", "f_farm_47_3", Rectangle(-2064.778, 726.2502, 30));
		AddSpawnPoint("f_farm_47_3.Id5", "f_farm_47_3", Rectangle(-2098.547, 944.594, 30));
		AddSpawnPoint("f_farm_47_3.Id5", "f_farm_47_3", Rectangle(-1948.513, 806.3783, 30));
		AddSpawnPoint("f_farm_47_3.Id5", "f_farm_47_3", Rectangle(-2181.0476, 871.29877, 30));
		AddSpawnPoint("f_farm_47_3.Id5", "f_farm_47_3", Rectangle(-1823.2194, -167.56242, 30));
		AddSpawnPoint("f_farm_47_3.Id5", "f_farm_47_3", Rectangle(-1400.2234, -373.08356, 30));
		AddSpawnPoint("f_farm_47_3.Id5", "f_farm_47_3", Rectangle(-2020.7048, 868.50085, 30));
		AddSpawnPoint("f_farm_47_3.Id5", "f_farm_47_3", Rectangle(-1524.4993, 773.14545, 30));
		AddSpawnPoint("f_farm_47_3.Id5", "f_farm_47_3", Rectangle(-1464.9429, 840.3034, 30));

		// 'Operor_White' GenType 38 Spawn Points
		AddSpawnPoint("f_farm_47_3.Id6", "f_farm_47_3", Rectangle(-1777.0542, -103.61743, 30));
		AddSpawnPoint("f_farm_47_3.Id6", "f_farm_47_3", Rectangle(-1821.9735, -200.15852, 30));
		AddSpawnPoint("f_farm_47_3.Id6", "f_farm_47_3", Rectangle(-1742.121, -15.889233, 30));
		AddSpawnPoint("f_farm_47_3.Id6", "f_farm_47_3", Rectangle(-1254.6552, 490.97046, 30));
		AddSpawnPoint("f_farm_47_3.Id6", "f_farm_47_3", Rectangle(-924.6795, 494.9204, 30));
		AddSpawnPoint("f_farm_47_3.Id6", "f_farm_47_3", Rectangle(-1125.3491, 512.178, 30));
		AddSpawnPoint("f_farm_47_3.Id6", "f_farm_47_3", Rectangle(-607.17285, 785.08014, 30));
		AddSpawnPoint("f_farm_47_3.Id6", "f_farm_47_3", Rectangle(-532.0166, 879.0556, 30));
		AddSpawnPoint("f_farm_47_3.Id6", "f_farm_47_3", Rectangle(-454.35468, 793.3214, 30));
		AddSpawnPoint("f_farm_47_3.Id6", "f_farm_47_3", Rectangle(377.91608, -26.571438, 30));
		AddSpawnPoint("f_farm_47_3.Id6", "f_farm_47_3", Rectangle(357.46924, 250.06001, 30));
		AddSpawnPoint("f_farm_47_3.Id6", "f_farm_47_3", Rectangle(498.49332, 99.71579, 30));
		AddSpawnPoint("f_farm_47_3.Id6", "f_farm_47_3", Rectangle(611.67487, -73.08181, 30));
		AddSpawnPoint("f_farm_47_3.Id6", "f_farm_47_3", Rectangle(311.80948, 109.41951, 30));
		AddSpawnPoint("f_farm_47_3.Id6", "f_farm_47_3", Rectangle(705.66266, 107.59396, 30));
		AddSpawnPoint("f_farm_47_3.Id6", "f_farm_47_3", Rectangle(-527.0202, 727.5278, 30));
		AddSpawnPoint("f_farm_47_3.Id6", "f_farm_47_3", Rectangle(-1274.9865, 549.67145, 30));
		AddSpawnPoint("f_farm_47_3.Id6", "f_farm_47_3", Rectangle(-744.7044, -398.99414, 30));
		AddSpawnPoint("f_farm_47_3.Id6", "f_farm_47_3", Rectangle(-606.7817, -319.045, 30));
		AddSpawnPoint("f_farm_47_3.Id6", "f_farm_47_3", Rectangle(-600.5685, -426.46503, 30));
		AddSpawnPoint("f_farm_47_3.Id6", "f_farm_47_3", Rectangle(-342.5068, -683.6852, 30));
		AddSpawnPoint("f_farm_47_3.Id6", "f_farm_47_3", Rectangle(-168.1669, -847.2657, 30));
		AddSpawnPoint("f_farm_47_3.Id6", "f_farm_47_3", Rectangle(12.148323, -660.82214, 30));
		AddSpawnPoint("f_farm_47_3.Id6", "f_farm_47_3", Rectangle(-157.5144, -549.3131, 30));
		AddSpawnPoint("f_farm_47_3.Id6", "f_farm_47_3", Rectangle(-33.432117, 81.32362, 30));
		AddSpawnPoint("f_farm_47_3.Id6", "f_farm_47_3", Rectangle(-162.0471, 37.520992, 30));
		AddSpawnPoint("f_farm_47_3.Id6", "f_farm_47_3", Rectangle(-1173.3529, 418.36295, 30));
		AddSpawnPoint("f_farm_47_3.Id6", "f_farm_47_3", Rectangle(-1649.881, -115.62052, 30));
		AddSpawnPoint("f_farm_47_3.Id6", "f_farm_47_3", Rectangle(-1327.6412, -313.41232, 30));
		AddSpawnPoint("f_farm_47_3.Id6", "f_farm_47_3", Rectangle(-1105.7047, -344.9906, 30));
		AddSpawnPoint("f_farm_47_3.Id6", "f_farm_47_3", Rectangle(-1270.0609, -517.88635, 30));
		AddSpawnPoint("f_farm_47_3.Id6", "f_farm_47_3", Rectangle(-1051.8303, -437.34094, 30));
		AddSpawnPoint("f_farm_47_3.Id6", "f_farm_47_3", Rectangle(-535.22644, -432.40012, 30));
		AddSpawnPoint("f_farm_47_3.Id6", "f_farm_47_3", Rectangle(-709.1125, -235.976, 30));
		AddSpawnPoint("f_farm_47_3.Id6", "f_farm_47_3", Rectangle(-841.51807, 367.55847, 30));
		AddSpawnPoint("f_farm_47_3.Id6", "f_farm_47_3", Rectangle(-861.022, 535.09265, 30));
		AddSpawnPoint("f_farm_47_3.Id6", "f_farm_47_3", Rectangle(-722.2924, 515.70264, 30));
		AddSpawnPoint("f_farm_47_3.Id6", "f_farm_47_3", Rectangle(-856.09906, 181.507, 30));
		AddSpawnPoint("f_farm_47_3.Id6", "f_farm_47_3", Rectangle(-815.8747, 736.1332, 30));
		AddSpawnPoint("f_farm_47_3.Id6", "f_farm_47_3", Rectangle(-755.4831, 822.0827, 30));
	}
}
