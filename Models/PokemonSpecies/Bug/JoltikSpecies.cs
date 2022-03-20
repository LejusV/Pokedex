using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Joltik Species to store common natural stats of all Joltiks
	#region JoltikSpecies
	public class JoltikSpecies : PokemonSpecies
	{
#nullable enable
		private static JoltikSpecies? _instance = null;
#nullable restore
        public static JoltikSpecies Instance => _instance ?? (_instance = new JoltikSpecies());

		#region JoltikSpecies Constructor
		public JoltikSpecies() : base(
			595,
			"Joltik",
			Bug.Instance, Electric.Instance,
			0.1,
			0.6,
			new PokemonStats(
				50, // HPs
				47, 50, // Attack & Defense
				57, 50, // Spacial Attack & Defense
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
				"Cut",
				"Poison-Sting",
				"Pin-Missile",
				"Disable",
				"Absorb",
				"String-Shot",
				"Thunderbolt",
				"Thunder-Wave",
				"Toxic",
				"Agility",
				"Screech",
				"Double-Team",
				"Light-Screen",
				"Leech-Life",
				"Flash",
				"Rest",
				"Slash",
				"Substitute",
				"Thief",
				"Spider-Web",
				"Snore",
				"Protect",
				"Feint-Attack",
				"Giga-Drain",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Hidden-Power",
				"Rain-Dance",
				"Facade",
				"Secret-Power",
				"Camouflage",
				"Signal-Beam",
				"Bounce",
				"Shock-Wave",
				"Gastro-Acid",
				"Sucker-Punch",
				"Magnet-Rise",
				"Poison-Jab",
				"X-Scissor",
				"Bug-Buzz",
				"Energy-Ball",
				"Rock-Climb",
				"Discharge",
				"Cross-Poison",
				"Bug-Bite",
				"Charge-Beam",
				"Electro-Ball",
				"Round",
				"Volt-Switch",
				"Struggle-Bug",
				"Electroweb",
				"Wild-Charge",
				"Confide",
				"Infestation",
				"Lunge"
			};
		}
		#endregion
	}
	#endregion
}