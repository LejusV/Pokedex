using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Jumpluff PokemonInstance Class
	#region Jumpluff
	public class Jumpluff : PokemonInstance
	{
		#region Jumpluff Constructors
		/// <summary>
		/// Jumpluff Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Jumpluff(string nickname, int level)
		: base(
				JumpluffSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Jumpluff Constructor only waiting for a Level
		/// </summary>
		public Jumpluff(int level)
		: this( "Jumpluff", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Jumpluff Constructor waiting for no params
		/// </summary>
		/*
		public Jumpluff() : this( "Jumpluff", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}