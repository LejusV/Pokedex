using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Vanilluxe Species to store common natural stats of all Vanilluxes
	#region SpeciesVanilluxe
	public class SpeciesVanilluxe : PokemonSpecies
	{
#nullable enable
		private static SpeciesVanilluxe? _instance = null;
#nullable restore
        public static SpeciesVanilluxe Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesVanilluxe();
                }
                return _instance;
            }
        }

		#region SpeciesVanilluxe Constructor
		public SpeciesVanilluxe() : base(
			"Vanilluxe",
			1.3,
			57.5,
			71, // HPs
			95, 85, // Attack & Defense
			110, 95, // Special Attack & Defense
			79		
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
				"Hyper-Beam",
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
				"Weather-Ball",
				"Signal-Beam",
				"Sheer-Cold",
				"Icicle-Spear",
				"Iron-Defense",
				"Water-Pulse",
				"Magnet-Rise",
				"Giga-Impact",
				"Avalanche",
				"Mirror-Shot",
				"Flash-Cannon",
				"Round",
				"Frost-Breath",
				"Freeze-Dry",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Vanilluxe PokemonInstance Class
	#region Vanilluxe
	public class VanilluxeInstance : PokemonInstance
	{
		#region Vanilluxe Constructors
		/// <summary>
		/// Vanilluxe Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public VanilluxeInstance(string nickname, int level)
		: base(
				584,
				SpeciesVanilluxe.Instance, // Pokemon Species
				nickname, level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vanilluxe Builder only waiting for a Level
		/// </summary>
		public VanilluxeInstance(int level)
		: base(
				584,
				SpeciesVanilluxe.Instance, // PokemonInstance Species
				"Vanilluxe", level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vanilluxe Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Vanilluxe() : base(
			584,
			SpeciesVanilluxe.Instance, // PokemonInstance Species
			Ice.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}