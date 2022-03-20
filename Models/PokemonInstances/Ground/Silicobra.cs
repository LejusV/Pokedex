using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Silicobra PokemonInstance Class
	#region Silicobra
	public class Silicobra : PokemonInstance
	{
		#region Silicobra Constructors
		/// <summary>
		/// Silicobra Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Silicobra(string nickname, int level)
		: base(
				SilicobraSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Silicobra Constructor only waiting for a Level
		/// </summary>
		public Silicobra(int level)
		: this( "Silicobra", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Silicobra Constructor waiting for no params
		/// </summary>
		/*
		public Silicobra() : this( "Silicobra", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}