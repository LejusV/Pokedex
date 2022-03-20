using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Tyrogue PokemonInstance Class
	#region Tyrogue
	public class Tyrogue : PokemonInstance
	{
		#region Tyrogue Constructors
		/// <summary>
		/// Tyrogue Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Tyrogue(string nickname, int level)
		: base(
				TyrogueSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tyrogue Constructor only waiting for a Level
		/// </summary>
		public Tyrogue(int level)
		: this( "Tyrogue", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tyrogue Constructor waiting for no params
		/// </summary>
		/*
		public Tyrogue() : this( "Tyrogue", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}