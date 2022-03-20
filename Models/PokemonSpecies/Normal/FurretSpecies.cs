using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Furret Species to store common natural stats of all Furrets
	#region FurretSpecies
	public class FurretSpecies : PokemonSpecies
	{
#nullable enable
		private static FurretSpecies? _instance = null;
#nullable restore
        public static FurretSpecies Instance => _instance ?? (_instance = new FurretSpecies());

		#region FurretSpecies Constructor
		public FurretSpecies() : base(
			162,
			"Furret",
			Normal.Instance,
			1.8,
			32.5,
			new PokemonStats(
				85, // HPs
				76, 64, // Attack & Defense
				45, 55, // Spacial Attack & Defense
				90 // Speed
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
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Scratch",
				"Cut",
				"Slam",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Flamethrower",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Strength",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder",
				"Dig",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Swift",
				"Amnesia",
				"Fury-Swipes",
				"Rest",
				"Super-Fang",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Foresight",
				"Detect",
				"Endure",
				"Rollout",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Baton-Pass",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Shadow-Ball",
				"Rock-Smash",
				"Whirlpool",
				"Uproar",
				"Facade",
				"Focus-Punch",
				"Follow-Me",
				"Helping-Hand",
				"Trick",
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Hyper-Voice",
				"Covet",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"U-Turn",
				"Fling",
				"Me-First",
				"Last-Resort",
				"Sucker-Punch",
				"Aqua-Tail",
				"Focus-Blast",
				"Giga-Impact",
				"Shadow-Claw",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Hone-Claws",
				"Coil",
				"Round",
				"Echoed-Voice",
				"Retaliate",
				"Work-Up",
				"Confide",
				"Power-Up-Punch",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}