using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Vanillite Species to store common natural stats of all Vanillites
	#region SpeciesVanillite
	public class SpeciesVanillite : PokemonSpecies
	{
#nullable enable
		private static SpeciesVanillite? _instance = null;
#nullable restore
        public static SpeciesVanillite Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesVanillite();
                }
                return _instance;
            }
        }

		#region SpeciesVanillite Constructor
		public SpeciesVanillite() : base(
			582,
			"Vanillite",
			0.4,
			5.7,
			36, // HPs
			50, 50, // Attack & Defense
			65, 60, // Special Attack & Defense
			44		
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
				"Powder-Snow",
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
				"Imprison",
				"Secret-Power",
				"Astonish",
				"Signal-Beam",
				"Sheer-Cold",
				"Icicle-Spear",
				"Iron-Defense",
				"Water-Pulse",
				"Natural-Gift",
				"Magnet-Rise",
				"Avalanche",
				"Ice-Shard",
				"Mirror-Shot",
				"Flash-Cannon",
				"Autotomize",
				"Round",
				"Frost-Breath",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Vanillite PokemonInstance Class
	#region Vanillite
	public class VanilliteInstance : PokemonInstance
	{
		#region Vanillite Constructors
		/// <summary>
		/// Vanillite Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public VanilliteInstance(string nickname, int level)
		: base(
				SpeciesVanillite.Instance, // Pokemon Species
				nickname, level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vanillite Builder only waiting for a Level
		/// </summary>
		public VanilliteInstance(int level)
		: base(
				SpeciesVanillite.Instance, // PokemonInstance Species
				"Vanillite", level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vanillite Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public VanilliteInstance() : base(
			SpeciesVanillite.Instance, // PokemonInstance Species
			Ice.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}