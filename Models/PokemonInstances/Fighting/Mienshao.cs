using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Mienshao PokemonInstance Class
	#region Mienshao
	public class Mienshao : PokemonInstance
	{
		#region Mienshao Constructors
		/// <summary>
		/// Mienshao Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Mienshao(string nickname, int level)
		: base(
				MienshaoSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mienshao Constructor only waiting for a Level
		/// </summary>
		public Mienshao(int level)
		: this( "Mienshao", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mienshao Constructor waiting for no params
		/// </summary>
		/*
		public Mienshao() : this( "Mienshao", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}