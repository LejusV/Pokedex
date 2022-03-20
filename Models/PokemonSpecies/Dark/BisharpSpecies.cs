using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Bisharp Species to store common natural stats of all Bisharps
	#region BisharpSpecies
	public class BisharpSpecies : PokemonSpecies
	{
#nullable enable
		private static BisharpSpecies? _instance = null;
#nullable restore
        public static BisharpSpecies Instance => _instance ?? (_instance = new BisharpSpecies());

		#region BisharpSpecies Constructor
		public BisharpSpecies() : base(
			625,
			"Bisharp",
			Dark.Instance, Steel.Instance,
			1.6,
			70.0,
			new PokemonStats(
				65, // HPs
				125, 100, // Attack & Defense
				60, 70, // Spacial Attack & Defense
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
				"Scratch",
				"Guillotine",
				"Swords-Dance",
				"Cut",
				"Leer",
				"Hyper-Beam",
				"Low-Kick",
				"Thunder-Wave",
				"Dig",
				"Toxic",
				"Double-Team",
				"Rest",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Spite",
				"Protect",
				"Scary-Face",
				"Feint-Attack",
				"Sandstorm",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Metal-Claw",
				"Hidden-Power",
				"Rain-Dance",
				"Rock-Smash",
				"Torment",
				"Facade",
				"Taunt",
				"Role-Play",
				"Brick-Break",
				"Knock-Off",
				"Snatch",
				"Secret-Power",
				"Rock-Tomb",
				"Metal-Sound",
				"Aerial-Ace",
				"Iron-Defense",
				"Metal-Burst",
				"Payback",
				"Assurance",
				"Embargo",
				"Fling",
				"Magnet-Rise",
				"Rock-Polish",
				"Poison-Jab",
				"Dark-Pulse",
				"Night-Slash",
				"X-Scissor",
				"Focus-Blast",
				"Giga-Impact",
				"Shadow-Claw",
				"Iron-Head",
				"Stone-Edge",
				"Stealth-Rock",
				"Grass-Knot",
				"Hone-Claws",
				"Low-Sweep",
				"Foul-Play",
				"Round",
				"Retaliate",
				"Dual-Chop",
				"Snarl",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}