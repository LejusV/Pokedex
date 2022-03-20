using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Kricketune Species to store common natural stats of all Kricketunes
	#region KricketuneSpecies
	public class KricketuneSpecies : PokemonSpecies
	{
#nullable enable
		private static KricketuneSpecies? _instance = null;
#nullable restore
        public static KricketuneSpecies Instance => _instance ?? (_instance = new KricketuneSpecies());

		#region KricketuneSpecies Constructor
		public KricketuneSpecies() : base(
			402,
			"Kricketune",
			Bug.Instance,
			1.0,
			25.5,
			new PokemonStats(
				77, // HPs
				85, 51, // Attack & Defense
				55, 51, // Spacial Attack & Defense
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
				"Swords-Dance",
				"Cut",
				"Growl",
				"Sing",
				"Hyper-Beam",
				"Strength",
				"Absorb",
				"String-Shot",
				"Toxic",
				"Screech",
				"Double-Team",
				"Focus-Energy",
				"Bide",
				"Leech-Life",
				"Flash",
				"Rest",
				"Slash",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Perish-Song",
				"Endure",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
				"Uproar",
				"Facade",
				"Taunt",
				"Brick-Break",
				"Knock-Off",
				"Endeavor",
				"Secret-Power",
				"Hyper-Voice",
				"Silver-Wind",
				"Aerial-Ace",
				"Natural-Gift",
				"Night-Slash",
				"X-Scissor",
				"Bug-Buzz",
				"Giga-Impact",
				"Captivate",
				"Bug-Bite",
				"Hone-Claws",
				"Round",
				"Echoed-Voice",
				"Struggle-Bug",
				"Sticky-Web",
				"Fell-Stinger",
				"Confide",
				"Infestation",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}