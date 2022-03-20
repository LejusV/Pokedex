using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Zorua Species to store common natural stats of all Zoruas
	#region ZoruaSpecies
	public class ZoruaSpecies : PokemonSpecies
	{
#nullable enable
		private static ZoruaSpecies? _instance = null;
#nullable restore
        public static ZoruaSpecies Instance => _instance ?? (_instance = new ZoruaSpecies());

		#region ZoruaSpecies Constructor
		public ZoruaSpecies() : base(
			570,
			"Zorua",
			Dark.Instance,
			0.7,
			12.5,
			new PokemonStats(
				40, // HPs
				65, 40, // Attack & Defense
				80, 40, // Spacial Attack & Defense
				65 // Speed
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
				"Scratch",
				"Swords-Dance",
				"Cut",
				"Leer",
				"Roar",
				"Counter",
				"Dig",
				"Toxic",
				"Agility",
				"Double-Team",
				"Fury-Swipes",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Spite",
				"Protect",
				"Scary-Face",
				"Feint-Attack",
				"Detect",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Uproar",
				"Torment",
				"Memento",
				"Facade",
				"Taunt",
				"Trick",
				"Knock-Off",
				"Imprison",
				"Snatch",
				"Secret-Power",
				"Hyper-Voice",
				"Fake-Tears",
				"Extrasensory",
				"Aerial-Ace",
				"Bounce",
				"Covet",
				"Calm-Mind",
				"U-Turn",
				"Payback",
				"Embargo",
				"Fling",
				"Copycat",
				"Punishment",
				"Sucker-Punch",
				"Dark-Pulse",
				"Nasty-Plot",
				"Captivate",
				"Grass-Knot",
				"Hone-Claws",
				"Foul-Play",
				"Round",
				"Incinerate",
				"Retaliate",
				"Night-Daze",
				"Snarl",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}