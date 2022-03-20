using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Zygarde PokemonInstance Class
	#region Zygarde
	public class Zygarde : PokemonInstance
	{
		#region Zygarde Constructors
		/// <summary>
		/// Zygarde Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Zygarde(string nickname, int level)
		: base(
				ZygardeSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zygarde Constructor only waiting for a Level
		/// </summary>
		public Zygarde(int level)
		: this( "Zygarde", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zygarde Constructor waiting for no params
		/// </summary>
		/*
		public Zygarde() : this( "Zygarde", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}