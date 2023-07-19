//--- Melia Script -----------------------------------------------------------
// ep13_2_d_prison_1
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Ashaq Underground Prison 1F' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class Ep132DPrison1MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners ---------------------------------

		AddSpawner("ep13_2_d_prison_1.Id1", MonsterId.Episode13_2_Goblin_Brandingiron, 72, 96, TimeSpan.FromMilliseconds(25000), TendencyType.Peaceful);
		AddSpawner("ep13_2_d_prison_1.Id2", MonsterId.Episode13_2_Banshee, 51, 68, TimeSpan.FromMilliseconds(25000), TendencyType.Peaceful);
		AddSpawner("ep13_2_d_prison_1.Id3", MonsterId.Episode13_2_Goblin_Sweeper, 93, 123, TimeSpan.FromMilliseconds(25000), TendencyType.Peaceful);
		AddSpawner("ep13_2_d_prison_1.Id4", MonsterId.Rootcrystal_01, 17, 22, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Episode13_2_Goblin_Brandingiron' GenType 1 Spawn Points
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(359.82675, -1028.4266, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(1175.4731, -1468.2169, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(1488.8606, -1427.4789, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(1529.7831, -1117.7377, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(1303.5807, -1232.816, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(1358.18, -997.58936, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(1054.9999, -1011.7349, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(849.09924, -1332.978, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(543.156, -1096.4773, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(363.21606, -1494.5062, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(853.8394, -873.9253, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(104.19116, -1443.5604, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(747.2501, -357.03238, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(869.86725, -388.6261, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(900.8084, -280.24963, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(763.20447, -233.52296, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(1170.398, -225.66501, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(1465.8024, -360.7992, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(1661.85, -350.95712, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(1549.229, -121.91275, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(1623.2205, 0.97075653, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(1668.7839, 170.82634, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(1615.7362, 263.39764, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(1665.5956, 368.24155, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(1662.4016, 492.19766, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(1656.6003, 676.7305, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(1898.139, 831.9967, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(1940.1489, 1181.0919, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(1839.7079, 991.91125, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(1652.3793, 1395.8593, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(1597.5935, 1096.1196, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(1398.6189, 900.57605, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(1238.6764, 749.3846, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(1141.8644, 635.51764, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(943.31744, 560.97266, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(742.4546, 620.13226, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(769.9462, 807.5227, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(992.2602, 710.40125, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(462.83917, 677.39984, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(609.0626, 657.8813, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(999.2869, 1487.4979, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(1145.2969, 1530.6307, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(1224.4061, 1382.5328, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(756.4086, 1353.9525, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(585.6548, 1491.4318, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(554.0086, 1266.3231, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(195.43091, 1295.5176, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(-100.48972, 1364.1055, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(-58.01142, 1259.144, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(109.7403, 1511.4746, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(-270.84866, 1537.1681, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(-512.353, 1526.0623, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(-756.07135, 1528.4073, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(-1031.4249, 1493.8617, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(-1423.718, 1580.7289, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(-1248.0607, 1553.1842, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(-1239.6261, 1434.4004, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(-1395.8416, 1326.2164, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(-1378.3615, 1120.4702, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(-1366.7478, 623.7135, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(-1341.9723, 497.1859, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(-1365.0082, 354.6692, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(-1379.8778, 180.11438, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(-1571.7854, -44.874695, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(-1512.0576, 167.13097, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(-1141.0327, 141.5865, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(-1132.824, -128.32158, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(-1071.5289, -55.50296, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(-1370.9191, -89.08746, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(-680.0473, 160.64488, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(-615.4998, -92.12662, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(-388.45926, 15.684315, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(-430.72342, 155.68524, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(-399.76825, 562.16455, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(-250.07709, 215.07979, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(-222.45654, 45.385506, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(1.3499565, -286.4447, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(370.58002, -292.47516, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(-501.3938, -637.99225, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(-390.36163, -679.16974, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(-435.41782, -858.22876, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(-495.27866, -1124.1927, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(-455.2039, -1395.5972, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(-785.6887, -1381.011, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(-1115.5038, -1343.1305, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(-1125.8055, -1475.9352, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(-1369.7748, -1303.1602, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(-1365.082, -1099.1348, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(-1334.7255, -672.34235, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(-1345.871, -503.2032, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(-1388.3997, -356.95816, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(-1387.8501, -1358.4072, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(-1418.7183, -1571.5326, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(-1456.6875, -1803.9034, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(-1294.4498, -1825.873, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id1", "ep13_2_d_prison_1", Rectangle(-1207.166, -1728.2765, 40));

		// 'Episode13_2_Banshee' GenType 2 Spawn Points
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(1392.7177, -1432.7349, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(1040.1532, -1080.9757, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(340.9214, -1229.8524, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(530.5095, -1441.7822, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(133.50464, -1001.9285, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(1574.2013, -246.39981, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(1438.8842, -35.1269, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(792.79956, -328.8569, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(-494.10263, -96.996475, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(-507.32065, 220.79659, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(874.91, 691.00323, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(1869.3057, 645.0733, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(1684.0688, 1009.7933, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(1807.3287, 1358.2322, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(1115.492, 1435.8629, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(434.5058, 1352.479, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(66.559845, 1418.7861, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(-1319.3309, -1401.7144, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(-1057.3232, -1378.3173, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(-1274.8721, 1330.4017, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(-1377.8594, 1536.5468, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(-1300.9642, -43.509354, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(-1459.3177, 185.61922, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(-1313.6051, -1732.616, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(-417.7222, -1339.635, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(-490.04898, -729.20374, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(316.59912, -1437.0281, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(74.35515, -1235.8396, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(809.4293, -1160.5583, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(1463.6509, -1087.8416, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(1151.4404, -1376.1721, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(1287.1407, -1188.1555, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(1411.9464, -286.33853, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(1639.93, -29.916832, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(1643.6514, 254.32578, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(1722.1401, 653.10144, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(1886.4429, 912.65894, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(1680.404, 884.4203, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(1949.5679, 1411.9689, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(1693.8063, 1343.3888, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(1299.5372, 879.0305, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(1247.7821, 758.87256, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(880.99054, 554.1963, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(961.2686, 792.9797, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(766.85724, 754.6643, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(1143.1361, 1313.4437, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(1006.6313, 1365.5919, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(306.39102, 1418.6038, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(219.21329, 1271.9731, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(-813.127, 1482.4062, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(-1020.5109, 1484.1838, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(-1380.4697, 1468.1833, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(-1254.2495, 1536.2224, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(-1340.8344, 583.8519, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(-1203.4863, 233.56274, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(-1402.5579, 52.18551, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(-1177.006, -226.602, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(-1435.1783, -124.5271, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(-566.96954, -36.416313, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(-611.49066, 171.39407, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(-412.592, -958.28876, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(-458.63043, -1372.571, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(-1155.2473, -1362.6019, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(-1394.4714, -1403.0133, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(-1293.0485, -1818.4076, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(-1186.6384, -1730.7854, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(-1366.0873, -480.40326, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id2", "ep13_2_d_prison_1", Rectangle(-1335.6523, -622.149, 40));

		// 'Episode13_2_Goblin_Sweeper' GenType 3 Spawn Points
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(1281.5621, -1482.1586, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(1539.5898, -1273.7966, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(1506.0441, -1057.2256, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(1305.1973, -962.0438, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(1343.5122, -1232.4791, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(1126.0781, -1040.9117, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(1048.9493, -1307.2577, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(773.6303, -1205.5017, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(785.239, -899.249, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(436.10184, -1485.3322, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(578.39276, -1181.635, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(289.04727, -1063.0927, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(112.05392, -1232.1599, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(205.40836, -1483.5945, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(339.83517, -1304.3241, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(677.3015, -267.69476, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(738.5007, -414.4324, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(809.18, -132.29158, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(825.76416, -38.238224, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(926.6188, -98.09615, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(936.7092, -350.7514, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(939.66046, -207.26497, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(1123.0632, -287.36023, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(1394.6165, -306.49026, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(1510.1952, -298.87537, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(1471.7446, -92.06181, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(1420.8656, 47.73028, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(1682.2849, -71.19222, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(1702.4971, -227.65715, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(1613.0089, -331.69977, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(1682.1002, 301.5892, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(1681.6433, 112.59599, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(1724.7798, 716.61865, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(1830.5575, 720.96216, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(1839.2012, 860.5304, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(1769.9034, 961.4794, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(1676.7461, 1139.8362, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(1907.6919, 1250.7004, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(1695.9679, 1318.0706, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(1448.7277, 963.8673, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(1290.153, 835.36523, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(1192.5566, 676.82806, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(969.0711, 502.8856, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(794.5637, 512.8579, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(821.6092, 634.6032, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(733.18787, 728.2071, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(850.6852, 824.7284, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(900.61285, 780.4219, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(1006.3497, 858.9108, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(999.4511, 1049.386, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(964.9831, 1154.2368, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(1188.8053, 1271.0844, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(1045.4681, 1276.895, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(937.0147, 1430.7701, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(1038.9971, 1557.9855, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(1207.8308, 1506.9299, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(813.11523, 1411.1223, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(485.23367, 1236.0537, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(521.33093, 1540.5715, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(406.34784, 1479.3749, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(314.7275, 1437.0398, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(273.1535, 1280.1604, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(138.19186, 1293.7612, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(8.209536, 1536.4374, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(8.695674, 1314.4086, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(-159.1472, 1530.2079, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(-813.1578, 1495.6895, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(-1062.339, 1435.9232, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(-1196.897, 1512.1755, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(-1286.1345, 1402.0319, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(-1421.6843, 1407.8036, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(-1457.5001, 1332.1718, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(-1494.104, 1567.3121, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(-1356.639, 1664.9371, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(-1362.8544, 1735.1232, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(-1406.6365, 1072.1292, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(-1343.5941, 1082.0192, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(274.05838, -324.89005, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(-79.88408, -312.88058, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(-234.45546, 84.35367, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(-280.90436, 134.24104, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(-443.17664, 75.8712, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(-488.32614, 288.5498, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(-431.7, 469.96222, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(-593.49207, 108.01376, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(-692.6938, 31.639456, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(-632.41876, -163.22095, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(-478.91162, -182.98172, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(-1226.0663, 307.17194, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(-1078.5039, 287.42993, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(-1069.4827, 61.13811, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(-1045.2057, -116.39166, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(-1154.6205, -195.8552, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(-1258.1779, 179.47563, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(-1315.6521, -156.88588, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(-1487.313, -136.25769, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(-1645.0139, 47.375137, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(-1413.1077, 94.95084, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(-1540.5361, 251.67305, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(-1320.3502, -415.31314, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(-1388.9934, -591.29144, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(-1390.2936, -876.32104, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(-1353.0393, -991.65247, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(-1389.2823, -1434.0604, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(-1445.2601, -1354.3152, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(-1275.303, -1333.322, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(-1214.3389, -1442.6196, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(-1026.1914, -1437.8661, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(-972.906, -1375.0159, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(-1006.9079, -1295.3042, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(-501.64484, -1346.0602, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(-403.31485, -1465.4803, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(-432.64102, -1230.9711, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(-373.19525, -1055.2068, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(-442.71872, -977.6277, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(-365.82214, -932.1829, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(-383.98456, -778.7644, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(-410.2901, -569.4219, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(-534.2422, -674.1123, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(-1350.7726, -1815.4183, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(-1225.3837, -1844.6923, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(-1182.7664, -1811.3746, 40));
		AddSpawnPoint("ep13_2_d_prison_1.Id3", "ep13_2_d_prison_1", Rectangle(-1214.7865, -1654.3186, 40));

		// 'Rootcrystal_01' GenType 18 Spawn Points
		AddSpawnPoint("ep13_2_d_prison_1.Id4", "ep13_2_d_prison_1", Rectangle(-521.771, 89.798004, 100));
		AddSpawnPoint("ep13_2_d_prison_1.Id4", "ep13_2_d_prison_1", Rectangle(3.2281876, -282.74323, 100));
		AddSpawnPoint("ep13_2_d_prison_1.Id4", "ep13_2_d_prison_1", Rectangle(399.0409, -287.32544, 100));
		AddSpawnPoint("ep13_2_d_prison_1.Id4", "ep13_2_d_prison_1", Rectangle(1128.2422, -249.16711, 100));
		AddSpawnPoint("ep13_2_d_prison_1.Id4", "ep13_2_d_prison_1", Rectangle(1661.9796, 294.46405, 100));
		AddSpawnPoint("ep13_2_d_prison_1.Id4", "ep13_2_d_prison_1", Rectangle(1784.5972, 791.1455, 100));
		AddSpawnPoint("ep13_2_d_prison_1.Id4", "ep13_2_d_prison_1", Rectangle(1804.106, 1187.6871, 100));
		AddSpawnPoint("ep13_2_d_prison_1.Id4", "ep13_2_d_prison_1", Rectangle(1308.1465, 868.6776, 100));
		AddSpawnPoint("ep13_2_d_prison_1.Id4", "ep13_2_d_prison_1", Rectangle(1015.0175, 1071.2688, 100));
		AddSpawnPoint("ep13_2_d_prison_1.Id4", "ep13_2_d_prison_1", Rectangle(1081.355, 1395.5918, 100));
		AddSpawnPoint("ep13_2_d_prison_1.Id4", "ep13_2_d_prison_1", Rectangle(584.97186, 1388.9203, 100));
		AddSpawnPoint("ep13_2_d_prison_1.Id4", "ep13_2_d_prison_1", Rectangle(56.829674, 1400.908, 100));
		AddSpawnPoint("ep13_2_d_prison_1.Id4", "ep13_2_d_prison_1", Rectangle(-463.51376, 1518.7753, 100));
		AddSpawnPoint("ep13_2_d_prison_1.Id4", "ep13_2_d_prison_1", Rectangle(-898.0988, 1531.8363, 100));
		AddSpawnPoint("ep13_2_d_prison_1.Id4", "ep13_2_d_prison_1", Rectangle(-1336.7936, 1568.7079, 100));
		AddSpawnPoint("ep13_2_d_prison_1.Id4", "ep13_2_d_prison_1", Rectangle(-1340.9354, 228.37683, 100));
		AddSpawnPoint("ep13_2_d_prison_1.Id4", "ep13_2_d_prison_1", Rectangle(-1354.8171, -93.680626, 100));
		AddSpawnPoint("ep13_2_d_prison_1.Id4", "ep13_2_d_prison_1", Rectangle(-1135.464, -1384.0967, 100));
		AddSpawnPoint("ep13_2_d_prison_1.Id4", "ep13_2_d_prison_1", Rectangle(-434.83597, -1007.1569, 100));
		AddSpawnPoint("ep13_2_d_prison_1.Id4", "ep13_2_d_prison_1", Rectangle(1289.6221, -1247.0812, 100));
		AddSpawnPoint("ep13_2_d_prison_1.Id4", "ep13_2_d_prison_1", Rectangle(324.83713, -1238.3583, 100));
		AddSpawnPoint("ep13_2_d_prison_1.Id4", "ep13_2_d_prison_1", Rectangle(787.3662, -950.7931, 100));
	}
}
