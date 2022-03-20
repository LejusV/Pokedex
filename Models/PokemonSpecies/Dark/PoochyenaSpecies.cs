using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Poochyena Species to store common natural stats of all Poochyenas
	#region PoochyenaSpecies
	public class PoochyenaSpecies : PokemonSpecies
	{
#nullable enable
		private static PoochyenaSpecies? _instance = null;
#nullable restore
        public static PoochyenaSpecies Instance => _instance ?? (_instance = new PoochyenaSpecies());

		#region PoochyenaSpecies Constructor
		public PoochyenaSpecies() : base(
			261,
			"Poochyena",
			Dark.Instance,
			0.5,
			13.6,
			new PokemonStats(
				35, // HPs
				55, 35, // Attack & Defense
				30, 30, // Spacial Attack & Defense
				35 // Speed
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
				"Sand-Attack",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Leer",
				"Bite",
				"Roar",
				"Counter",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Rest",
				"Super-Fang",
				"Substitute",
				"Thief",
				"Snore",
				"Spite",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Psych-Up",
				"Shadow-Ball",
				"Rock-Smash",
				"Uproar",
				"Torment",
				"Facade",
				"Taunt",
				"Yawn",
				"Snatch",
				"Secret-Power",
				"Hyper-Voice",
				"Poison-Fang",
				"Astonish",
				"Odor-Sleuth",
				"Howl",
				"Covet",
				"Natural-Gift",
				"Payback",
				"Assurance",
				"Embargo",
				"Me-First",
				"Sucker-Punch",
				"Dark-Pulse",
				"Thunder-Fang",
				"Ice-Fang",
				"Fire-Fang",
				"Captivate",
				"Foul-Play",
				"Round",
				"Incinerate",
				"Retaliate",
				"Snarl",
				"Play-Rough",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}