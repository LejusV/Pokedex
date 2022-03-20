using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Sentret PokemonInstance Class
	#region Sentret
	public class Sentret : PokemonInstance
	{
		#region Sentret Constructors
		/// <summary>
		/// Sentret Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Sentret(string nickname, int level)
		: base(
				SentretSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sentret Constructor only waiting for a Level
		/// </summary>
		public Sentret(int level)
		: this( "Sentret", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sentret Constructor waiting for no params
		/// </summary>
		/*
		public Sentret() : this( "Sentret", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}