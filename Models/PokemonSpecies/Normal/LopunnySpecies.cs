using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Lopunny Species to store common natural stats of all Lopunnys
	#region LopunnySpecies
	public class LopunnySpecies : PokemonSpecies
	{
#nullable enable
		private static LopunnySpecies? _instance = null;
#nullable restore
        public static LopunnySpecies Instance => _instance ?? (_instance = new LopunnySpecies());

		#region LopunnySpecies Constructor
		public LopunnySpecies() : base(
			428,
			"Lopunny",
			Normal.Instance,
			1.2,
			33.3,
			new PokemonStats(
				65, // HPs
				76, 84, // Attack & Defense
				54, 96, // Spacial Attack & Defense
				105 // Speed
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
				"Pound",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Cut",
				"Jump-Kick",
				"Headbutt",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Low-Kick",
				"Strength",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Dig",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Double-Team",
				"Defense-Curl",
				"Swift",
				"High-Jump-Kick",
				"Dizzy-Punch",
				"Splash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Foresight",
				"Endure",
				"Charm",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Baton-Pass",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Mirror-Coat",
				"Shadow-Ball",
				"Rock-Smash",
				"Uproar",
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Magic-Coat",
				"Endeavor",
				"Secret-Power",
				"Hyper-Voice",
				"Bounce",
				"Covet",
				"Shock-Wave",
				"Water-Pulse",
				"Healing-Wish",
				"Natural-Gift",
				"Fling",
				"Last-Resort",
				"Drain-Punch",
				"Focus-Blast",
				"Giga-Impact",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Low-Sweep",
				"Entrainment",
				"After-You",
				"Round",
				"Retaliate",
				"Work-Up",
				"Rototiller",
				"Confide",
				"Baby-Doll-Eyes",
				"Power-Up-Punch",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}