using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Petilil PokemonInstance Class
	#region Petilil
	public class Petilil : PokemonInstance
	{
		#region Petilil Constructors
		/// <summary>
		/// Petilil Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Petilil(string nickname, int level)
		: base(
				PetililSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Petilil Constructor only waiting for a Level
		/// </summary>
		public Petilil(int level)
		: this( "Petilil", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Petilil Constructor waiting for no params
		/// </summary>
		/*
		public Petilil() : this( "Petilil", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}