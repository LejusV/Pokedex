using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Delibird Species to store common natural stats of all Delibirds
	#region DelibirdSpecies
	public class DelibirdSpecies : PokemonSpecies
	{
#nullable enable
		private static DelibirdSpecies? _instance = null;
#nullable restore
        public static DelibirdSpecies Instance => _instance ?? (_instance = new DelibirdSpecies());

		#region DelibirdSpecies Constructor
		public DelibirdSpecies() : base(
			225,
			"Delibird",
			Ice.Instance, Flying.Instance,
			0.9,
			16.0,
			new PokemonStats(
				45, // HPs
				55, 45, // Attack & Defense
				65, 45, // Spacial Attack & Defense
				75 // Speed
			)			
		)
		{
			InitMovesList();
		}
		#endregion

		#region Methods
		private void InitMovesList()
		{
			_moveList = new List<string>()
			{
				"Mega-Punch",
				"Ice-Punch",
				"Fly",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Ice-Beam",
				"Blizzard",
				"Aurora-Beam",
				"Drill-Peck",
				"Counter",
				"Seismic-Toss",
				"Toxic",
				"Quick-Attack",
				"Mimic",
				"Double-Team",
				"Swift",
				"Sky-Attack",
				"Splash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Spikes",
				"Destiny-Bond",
				"Icy-Wind",
				"Detect",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Present",
				"Frustration",
				"Rapid-Spin",
				"Hidden-Power",
				"Rain-Dance",
				"Future-Sight",
				"Fake-Out",
				"Hail",
				"Facade",
				"Focus-Punch",
				"Recycle",
				"Brick-Break",
				"Secret-Power",
				"Ice-Ball",
				"Signal-Beam",
				"Aerial-Ace",
				"Bounce",
				"Water-Pulse",
				"Natural-Gift",
				"Pluck",
				"Fling",
				"Seed-Bomb",
				"Avalanche",
				"Ice-Shard",
				"Defog",
				"Gunk-Shot",
				"Captivate",
				"Round",
				"Bestow",
				"Frost-Breath",
				"Freeze-Dry",
				"Confide",
				"Power-Up-Punch",
				"Brutal-Swing",
				"Aurora-Veil"
			};
		}
		#endregion
	}
	#endregion
}