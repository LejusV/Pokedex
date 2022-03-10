using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Melmetal Species to store common natural stats of all Melmetals
	#region SpeciesMelmetal
	public class SpeciesMelmetal : PokemonSpecies
	{
#nullable enable
		private static SpeciesMelmetal? _instance = null;
#nullable restore
        public static SpeciesMelmetal Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMelmetal();
                }
                return _instance;
            }
        }

		#region SpeciesMelmetal Constructor
		public SpeciesMelmetal() : base(
			"Melmetal",
			2.5,
			800.0,
			135, // HPs
			143, 143, // Attack & Defense
			80, 65, // Special Attack & Defense
			34		
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
				
			};
		}
		#endregion
	}
	#endregion

	//Melmetal PokemonInstance Class
	#region Melmetal
	public class MelmetalInstance : PokemonInstance
	{
		#region Melmetal Constructors
		/// <summary>
		/// Melmetal Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MelmetalInstance(string nickname, int level)
		: base(
				809,
				SpeciesMelmetal.Instance, // Pokemon Species
				nickname, level,
				Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Melmetal Builder only waiting for a Level
		/// </summary>
		public MelmetalInstance(int level)
		: base(
				809,
				SpeciesMelmetal.Instance, // PokemonInstance Species
				"Melmetal", level,
				Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Melmetal Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Melmetal() : base(
			809,
			SpeciesMelmetal.Instance, // PokemonInstance Species
			Steel.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}