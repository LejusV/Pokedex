using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Xerneas PokemonInstance Class
	#region Xerneas
	public class Xerneas : PokemonInstance
	{
		#region Xerneas Constructors
		/// <summary>
		/// Xerneas Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Xerneas(string nickname, int level)
		: base(
				XerneasSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Xerneas Constructor only waiting for a Level
		/// </summary>
		public Xerneas(int level)
		: this( "Xerneas", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Xerneas Constructor waiting for no params
		/// </summary>
		/*
		public Xerneas() : this( "Xerneas", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}