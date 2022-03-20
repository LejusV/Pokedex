using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Pawniard Species to store common natural stats of all Pawniards
	#region PawniardSpecies
	public class PawniardSpecies : PokemonSpecies
	{
#nullable enable
		private static PawniardSpecies? _instance = null;
#nullable restore
        public static PawniardSpecies Instance => _instance ?? (_instance = new PawniardSpecies());

		#region PawniardSpecies Constructor
		public PawniardSpecies() : base(
			624,
			"Pawniard",
			Dark.Instance, Steel.Instance,
			0.5,
			10.2,
			new PokemonStats(
				45, // HPs
				85, 70, // Attack & Defense
				40, 40, // Spacial Attack & Defense
				60 // Speed
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
				"Headbutt",
				"Leer",
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
				"Mean-Look",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Metal-Claw",
				"Hidden-Power",
				"Rain-Dance",
				"Rock-Smash",
				"Torment",
				"Facade",
				"Taunt",
				"Role-Play",
				"Revenge",
				"Brick-Break",
				"Knock-Off",
				"Snatch",
				"Secret-Power",
				"Rock-Tomb",
				"Metal-Sound",
				"Aerial-Ace",
				"Iron-Defense",
				"Payback",
				"Assurance",
				"Embargo",
				"Fling",
				"Sucker-Punch",
				"Magnet-Rise",
				"Rock-Polish",
				"Poison-Jab",
				"Dark-Pulse",
				"Night-Slash",
				"X-Scissor",
				"Shadow-Claw",
				"Psycho-Cut",
				"Iron-Head",
				"Stealth-Rock",
				"Grass-Knot",
				"Hone-Claws",
				"Low-Sweep",
				"Foul-Play",
				"Round",
				"Quick-Guard",
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