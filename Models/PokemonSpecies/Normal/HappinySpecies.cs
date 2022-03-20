using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Happiny Species to store common natural stats of all Happinys
	#region HappinySpecies
	public class HappinySpecies : PokemonSpecies
	{
#nullable enable
		private static HappinySpecies? _instance = null;
#nullable restore
        public static HappinySpecies Instance => _instance ?? (_instance = new HappinySpecies());

		#region HappinySpecies Constructor
		public HappinySpecies() : base(
			440,
			"Happiny",
			Normal.Instance,
			0.6,
			24.4,
			new PokemonStats(
				100, // HPs
				5, 5, // Attack & Defense
				15, 65, // Spacial Attack & Defense
				30 // Speed
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
				"Headbutt",
				"Flamethrower",
				"Counter",
				"Solar-Beam",
				"Thunder-Wave",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Metronome",
				"Fire-Blast",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Sweet-Kiss",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Charm",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Present",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Uproar",
				"Hail",
				"Facade",
				"Helping-Hand",
				"Recycle",
				"Endeavor",
				"Refresh",
				"Secret-Power",
				"Hyper-Voice",
				"Aromatherapy",
				"Covet",
				"Shock-Wave",
				"Water-Pulse",
				"Gravity",
				"Natural-Gift",
				"Fling",
				"Copycat",
				"Last-Resort",
				"Drain-Punch",
				"Mud-Bomb",
				"Zen-Headbutt",
				"Captivate",
				"Grass-Knot",
				"Round",
				"Echoed-Voice",
				"Incinerate",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}