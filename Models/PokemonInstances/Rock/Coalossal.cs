using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Coalossal PokemonInstance Class
	#region Coalossal
	public class Coalossal : PokemonInstance
	{
		#region Coalossal Constructors
		/// <summary>
		/// Coalossal Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Coalossal(string nickname, int level)
		: base(
				CoalossalSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Coalossal Constructor only waiting for a Level
		/// </summary>
		public Coalossal(int level)
		: this( "Coalossal", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Coalossal Constructor waiting for no params
		/// </summary>
		/*
		public Coalossal() : this( "Coalossal", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}