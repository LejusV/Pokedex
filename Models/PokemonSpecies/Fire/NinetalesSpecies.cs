using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Ninetales Species to store common natural stats of all Ninetaless
	#region NinetalesSpecies
	public class NinetalesSpecies : PokemonSpecies
	{
#nullable enable
		private static NinetalesSpecies? _instance = null;
#nullable restore
        public static NinetalesSpecies Instance => _instance ?? (_instance = new NinetalesSpecies());

		#region NinetalesSpecies Constructor
		public NinetalesSpecies() : base(
			38,
			"Ninetales",
			Fire.Instance,
			1.1,
			19.9,
			new PokemonStats(
				73, // HPs
				76, 75, // Attack & Defense
				81, 100, // Spacial Attack & Defense
				100 // Speed
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
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Tail-Whip",
				"Roar",
				"Ember",
				"Flamethrower",
				"Hyper-Beam",
				"Solar-Beam",
				"Fire-Spin",
				"Dig",
				"Toxic",
				"Quick-Attack",
				"Rage",
				"Mimic",
				"Double-Team",
				"Confuse-Ray",
				"Reflect",
				"Bide",
				"Fire-Blast",
				"Swift",
				"Skull-Bash",
				"Dream-Eater",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Spite",
				"Protect",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Pain-Split",
				"Iron-Tail",
				"Hidden-Power",
				"Sunny-Day",
				"Psych-Up",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Role-Play",
				"Imprison",
				"Secret-Power",
				"Overheat",
				"Covet",
				"Calm-Mind",
				"Natural-Gift",
				"Payback",
				"Dark-Pulse",
				"Energy-Ball",
				"Giga-Impact",
				"Nasty-Plot",
				"Zen-Headbutt",
				"Captivate",
				"Ominous-Wind",
				"Psyshock",
				"Flame-Charge",
				"Foul-Play",
				"Round",
				"Incinerate",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}