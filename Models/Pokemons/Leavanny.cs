using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Leavanny Species to store common natural stats of all Leavannys
	#region SpeciesLeavanny
	public class SpeciesLeavanny : PokemonSpecies
	{
#nullable enable
		private static SpeciesLeavanny? _instance = null;
#nullable restore
        public static SpeciesLeavanny Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesLeavanny();
                }
                return _instance;
            }
        }

		#region SpeciesLeavanny Constructor
		public SpeciesLeavanny() : base(
			"Leavanny",
			1.2,
			20.5,
			75, // HPs
			103, 80, // Attack & Defense
			70, 80, // Special Attack & Defense
			92		
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
				"Tackle",
				"Hyper-Beam",
				"Razor-Leaf",
				"Solar-Beam",
				"String-Shot",
				"Toxic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Slash",
				"Substitute",
				"Snore",
				"Protect",
				"Giga-Drain",
				"False-Swipe",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Facade",
				"Nature-Power",
				"Helping-Hand",
				"Magic-Coat",
				"Knock-Off",
				"Secret-Power",
				"Signal-Beam",
				"Aerial-Ace",
				"Iron-Defense",
				"Calm-Mind",
				"Leaf-Blade",
				"Payback",
				"Worry-Seed",
				"Poison-Jab",
				"Seed-Bomb",
				"X-Scissor",
				"Energy-Ball",
				"Giga-Impact",
				"Shadow-Claw",
				"Leaf-Storm",
				"Grass-Knot",
				"Bug-Bite",
				"Hone-Claws",
				"Entrainment",
				"Round",
				"Retaliate",
				"Struggle-Bug",
				"Electroweb",
				"Fell-Stinger",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Leavanny PokemonInstance Class
	#region Leavanny
	public class LeavannyInstance : PokemonInstance
	{
		#region Leavanny Constructors
		/// <summary>
		/// Leavanny Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public LeavannyInstance(string nickname, int level)
		: base(
				542,
				SpeciesLeavanny.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Leavanny Builder only waiting for a Level
		/// </summary>
		public LeavannyInstance(int level)
		: base(
				542,
				SpeciesLeavanny.Instance, // PokemonInstance Species
				"Leavanny", level,
				Bug.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Leavanny Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Leavanny() : base(
			542,
			SpeciesLeavanny.Instance, // PokemonInstance Species
			Bug.Instance, Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}