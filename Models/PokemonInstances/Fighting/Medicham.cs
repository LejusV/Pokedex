using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Medicham PokemonInstance Class
	#region Medicham
	public class Medicham : PokemonInstance
	{
		#region Medicham Constructors
		/// <summary>
		/// Medicham Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Medicham(string nickname, int level)
		: base(
				MedichamSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Medicham Constructor only waiting for a Level
		/// </summary>
		public Medicham(int level)
		: this( "Medicham", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Medicham Constructor waiting for no params
		/// </summary>
		/*
		public Medicham() : this( "Medicham", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}