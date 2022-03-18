using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Galvantula Species to store common natural stats of all Galvantulas
	#region SpeciesGalvantula
	public class SpeciesGalvantula : PokemonSpecies
	{
#nullable enable
		private static SpeciesGalvantula? _instance = null;
#nullable restore
        public static SpeciesGalvantula Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesGalvantula();
                }
                return _instance;
            }
        }

		#region SpeciesGalvantula Constructor
		public SpeciesGalvantula() : base(
			596,
			"Galvantula",
			0.8,
			14.3,
			70, // HPs
			77, 60, // Attack & Defense
			97, 60, // Special Attack & Defense
			108		
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
				"Hyper-Beam",
				"Absorb",
				"String-Shot",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
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
				"Giga-Drain",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Facade",
				"Secret-Power",
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
				"Giga-Impact",
				"Discharge",
				"Bug-Bite",
				"Charge-Beam",
				"Electro-Ball",
				"Round",
				"Volt-Switch",
				"Struggle-Bug",
				"Electroweb",
				"Wild-Charge",
				"Sticky-Web",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion

	//Galvantula PokemonInstance Class
	#region Galvantula
	public class GalvantulaInstance : PokemonInstance
	{
		#region Galvantula Constructors
		/// <summary>
		/// Galvantula Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public GalvantulaInstance(string nickname, int level)
		: base(
				SpeciesGalvantula.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance, Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Galvantula Builder only waiting for a Level
		/// </summary>
		public GalvantulaInstance(int level)
		: base(
				SpeciesGalvantula.Instance, // PokemonInstance Species
				"Galvantula", level,
				Bug.Instance, Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Galvantula Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public GalvantulaInstance() : base(
			SpeciesGalvantula.Instance, // PokemonInstance Species
			Bug.Instance, Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}