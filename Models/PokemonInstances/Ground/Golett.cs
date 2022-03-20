using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Golett PokemonInstance Class
	#region Golett
	public class Golett : PokemonInstance
	{
		#region Golett Constructors
		/// <summary>
		/// Golett Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Golett(string nickname, int level)
		: base(
				GolettSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Golett Constructor only waiting for a Level
		/// </summary>
		public Golett(int level)
		: this( "Golett", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Golett Constructor waiting for no params
		/// </summary>
		/*
		public Golett() : this( "Golett", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}