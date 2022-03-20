using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Mamoswine PokemonInstance Class
	#region Mamoswine
	public class Mamoswine : PokemonInstance
	{
		#region Mamoswine Constructors
		/// <summary>
		/// Mamoswine Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Mamoswine(string nickname, int level)
		: base(
				MamoswineSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mamoswine Constructor only waiting for a Level
		/// </summary>
		public Mamoswine(int level)
		: this( "Mamoswine", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mamoswine Constructor waiting for no params
		/// </summary>
		/*
		public Mamoswine() : this( "Mamoswine", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}