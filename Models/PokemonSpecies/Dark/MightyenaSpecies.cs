using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Mightyena Species to store common natural stats of all Mightyenas
	#region MightyenaSpecies
	public class MightyenaSpecies : PokemonSpecies
	{
#nullable enable
		private static MightyenaSpecies? _instance = null;
#nullable restore
        public static MightyenaSpecies Instance => _instance ?? (_instance = new MightyenaSpecies());

		#region MightyenaSpecies Constructor
		public MightyenaSpecies() : base(
			262,
			"Mightyena",
			Dark.Instance,
			1.0,
			37.0,
			new PokemonStats(
				70, // HPs
				90, 70, // Attack & Defense
				60, 60, // Spacial Attack & Defense
				70 // Speed
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
				"Bite",
				"Roar",
				"Hyper-Beam",
				"Counter",
				"Strength",
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
				"Odor-Sleuth",
				"Howl",
				"Covet",
				"Natural-Gift",
				"Payback",
				"Assurance",
				"Embargo",
				"Sucker-Punch",
				"Dark-Pulse",
				"Giga-Impact",
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