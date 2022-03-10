using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Kartana Species to store common natural stats of all Kartanas
	#region SpeciesKartana
	public class SpeciesKartana : PokemonSpecies
	{
#nullable enable
		private static SpeciesKartana? _instance = null;
#nullable restore
        public static SpeciesKartana Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesKartana();
                }
                return _instance;
            }
        }

		#region SpeciesKartana Constructor
		public SpeciesKartana() : base(
			"Kartana",
			0.3,
			0.1,
			59, // HPs
			181, 131, // Attack & Defense
			59, 31, // Special Attack & Defense
			109		
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
				"Guillotine",
				"Swords-Dance",
				"Cut",
				"Razor-Leaf",
				"Toxic",
				"Double-Team",
				"Rest",
				"Substitute",
				"Protect",
				"Detect",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Synthesis",
				"Hidden-Power",
				"Brick-Break",
				"Air-Cutter",
				"Aerial-Ace",
				"Calm-Mind",
				"Leaf-Blade",
				"Night-Slash",
				"Air-Slash",
				"X-Scissor",
				"Vacuum-Wave",
				"Giga-Impact",
				"Psycho-Cut",
				"Defog",
				"Round",
				"Sacred-Sword",
				"Confide",
				"Laser-Focus",
				"Smart-Strike"
			};
		}
		#endregion
	}
	#endregion

	//Kartana PokemonInstance Class
	#region Kartana
	public class KartanaInstance : PokemonInstance
	{
		#region Kartana Constructors
		/// <summary>
		/// Kartana Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public KartanaInstance(string nickname, int level)
		: base(
				798,
				SpeciesKartana.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kartana Builder only waiting for a Level
		/// </summary>
		public KartanaInstance(int level)
		: base(
				798,
				SpeciesKartana.Instance, // PokemonInstance Species
				"Kartana", level,
				Grass.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kartana Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Kartana() : base(
			798,
			SpeciesKartana.Instance, // PokemonInstance Species
			Grass.Instance, Steel.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}