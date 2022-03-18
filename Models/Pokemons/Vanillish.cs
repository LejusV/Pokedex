using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Vanillish Species to store common natural stats of all Vanillishs
	#region SpeciesVanillish
	public class SpeciesVanillish : PokemonSpecies
	{
#nullable enable
		private static SpeciesVanillish? _instance = null;
#nullable restore
        public static SpeciesVanillish Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesVanillish();
                }
                return _instance;
            }
        }

		#region SpeciesVanillish Constructor
		public SpeciesVanillish() : base(
			583,
			"Vanillish",
			1.1,
			41.0,
			51, // HPs
			65, 65, // Attack & Defense
			80, 75, // Special Attack & Defense
			59		
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
				"Mist",
				"Ice-Beam",
				"Blizzard",
				"Toxic",
				"Double-Team",
				"Harden",
				"Light-Screen",
				"Acid-Armor",
				"Explosion",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Icy-Wind",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Mirror-Coat",
				"Uproar",
				"Hail",
				"Facade",
				"Taunt",
				"Magic-Coat",
				"Secret-Power",
				"Astonish",
				"Signal-Beam",
				"Sheer-Cold",
				"Icicle-Spear",
				"Iron-Defense",
				"Water-Pulse",
				"Magnet-Rise",
				"Avalanche",
				"Mirror-Shot",
				"Flash-Cannon",
				"Round",
				"Frost-Breath",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Vanillish PokemonInstance Class
	#region Vanillish
	public class VanillishInstance : PokemonInstance
	{
		#region Vanillish Constructors
		/// <summary>
		/// Vanillish Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public VanillishInstance(string nickname, int level)
		: base(
				SpeciesVanillish.Instance, // Pokemon Species
				nickname, level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vanillish Builder only waiting for a Level
		/// </summary>
		public VanillishInstance(int level)
		: base(
				SpeciesVanillish.Instance, // PokemonInstance Species
				"Vanillish", level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vanillish Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public VanillishInstance() : base(
			SpeciesVanillish.Instance, // PokemonInstance Species
			Ice.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}