using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Snivy PokemonInstance Class
	#region Snivy
	public class Snivy : PokemonInstance
	{
		#region Snivy Constructors
		/// <summary>
		/// Snivy Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Snivy(string nickname, int level)
		: base(
				SnivySpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Snivy Constructor only waiting for a Level
		/// </summary>
		public Snivy(int level)
		: this( "Snivy", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Snivy Constructor waiting for no params
		/// </summary>
		/*
		public Snivy() : this( "Snivy", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}