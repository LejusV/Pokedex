using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Joltik Species to store common natural stats of all Joltiks
	#region SpeciesJoltik
	public class SpeciesJoltik : PokemonSpecies
	{
#nullable enable
		private static SpeciesJoltik? _instance = null;
#nullable restore
        public static SpeciesJoltik Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesJoltik();
                }
                return _instance;
            }
        }

		#region SpeciesJoltik Constructor
		public SpeciesJoltik() : base(
			"Joltik",
			0.1,
			0.6,
			50, // HPs
			47, 50, // Attack & Defense
			57, 50, // Special Attack & Defense
			65		
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

	//Joltik PokemonInstance Class
	#region Joltik
	public class JoltikInstance : PokemonInstance
	{
		#region Joltik Constructors
		/// <summary>
		/// Joltik Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public JoltikInstance(string nickname, int level)
		: base(
				595,
				SpeciesJoltik.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance, Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Joltik Builder only waiting for a Level
		/// </summary>
		public JoltikInstance(int level)
		: base(
				595,
				SpeciesJoltik.Instance, // PokemonInstance Species
				"Joltik", level,
				Bug.Instance, Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Joltik Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Joltik() : base(
			595,
			SpeciesJoltik.Instance, // PokemonInstance Species
			Bug.Instance, Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}