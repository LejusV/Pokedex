using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Shaymin-Land Species to store common natural stats of all Shaymin-Lands
	#region SpeciesShaymin-Land
	public class SpeciesShayminLand : PokemonSpecies
	{
#nullable enable
		private static SpeciesShayminLand? _instance = null;
#nullable restore
        public static SpeciesShayminLand Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesShayminLand();
                }
                return _instance;
            }
        }

		#region SpeciesShaymin-Land Constructor
		public SpeciesShayminLand() : base(
			"Shaymin-Land",
			0.2,
			2.1,
			100, // HPs
			100, 100, // Attack & Defense
			100, 100, // Special Attack & Defense
			100		
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
				"Headbutt",
				"Hyper-Beam",
				"Leech-Seed",
				"Growth",
				"Solar-Beam",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Defense-Curl",
				"Swift",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Sweet-Kiss",
				"Mud-Slap",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Sweet-Scent",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Psych-Up",
				"Facade",
				"Nature-Power",
				"Endeavor",
				"Secret-Power",
				"Aromatherapy",
				"Grass-Whistle",
				"Bullet-Seed",
				"Covet",
				"Magical-Leaf",
				"Healing-Wish",
				"Natural-Gift",
				"Lucky-Chant",
				"Last-Resort",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Earth-Power",
				"Giga-Impact",
				"Zen-Headbutt",
				"Grass-Knot",
				"Seed-Flare",
				"Round",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion

	//Shaymin-Land PokemonInstance Class
	#region Shaymin-Land
	public class ShayminLandInstance : PokemonInstance
	{
		#region Shaymin-Land Constructors
		/// <summary>
		/// Shaymin-Land Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ShayminLandInstance(string nickname, int level)
		: base(
				492,
				SpeciesShayminLand.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shaymin-Land Builder only waiting for a Level
		/// </summary>
		public ShayminLandInstance(int level)
		: base(
				492,
				SpeciesShayminLand.Instance, // PokemonInstance Species
				"Shaymin-Land", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shaymin-Land Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public ShayminLand() : base(
			492,
			SpeciesShayminLand.Instance, // PokemonInstance Species
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}