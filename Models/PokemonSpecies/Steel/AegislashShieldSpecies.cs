using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Aegislash-Shield Species to store common natural stats of all Aegislash-Shields
	#region Aegislash-ShieldSpecies
	public class AegislashShieldSpecies : PokemonSpecies
	{
#nullable enable
		private static AegislashShieldSpecies? _instance = null;
#nullable restore
        public static AegislashShieldSpecies Instance => _instance ?? (_instance = new AegislashShieldSpecies());

		#region Aegislash-ShieldSpecies Constructor
		public AegislashShieldSpecies() : base(
			681,
			"Aegislash-Shield",
			Steel.Instance, Ghost.Instance,
			1.7,
			53.0,
			new PokemonStats(
				60, // HPs
				50, 140, // Attack & Defense
				50, 140, // Spacial Attack & Defense
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
				"Swords-Dance",
				"Cut",
				"Hyper-Beam",
				"Toxic",
				"Double-Team",
				"Reflect",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Snore",
				"Spite",
				"Protect",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Shadow-Ball",
				"Rock-Smash",
				"Facade",
				"Brick-Break",
				"Secret-Power",
				"Aerial-Ace",
				"Iron-Defense",
				"Block",
				"Shock-Wave",
				"Gyro-Ball",
				"Power-Trick",
				"Magnet-Rise",
				"Night-Slash",
				"Giga-Impact",
				"Shadow-Claw",
				"Shadow-Sneak",
				"Flash-Cannon",
				"Iron-Head",
				"Head-Smash",
				"Autotomize",
				"After-You",
				"Round",
				"Retaliate",
				"Sacred-Sword",
				"Kings-Shield",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}