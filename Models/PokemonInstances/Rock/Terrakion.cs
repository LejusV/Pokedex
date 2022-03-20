using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Terrakion PokemonInstance Class
	#region Terrakion
	public class Terrakion : PokemonInstance
	{
		#region Terrakion Constructors
		/// <summary>
		/// Terrakion Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Terrakion(string nickname, int level)
		: base(
				TerrakionSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Terrakion Constructor only waiting for a Level
		/// </summary>
		public Terrakion(int level)
		: this( "Terrakion", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Terrakion Constructor waiting for no params
		/// </summary>
		/*
		public Terrakion() : this( "Terrakion", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}