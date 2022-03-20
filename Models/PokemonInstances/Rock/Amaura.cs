using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Amaura PokemonInstance Class
	#region Amaura
	public class Amaura : PokemonInstance
	{
		#region Amaura Constructors
		/// <summary>
		/// Amaura Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Amaura(string nickname, int level)
		: base(
				AmauraSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Amaura Constructor only waiting for a Level
		/// </summary>
		public Amaura(int level)
		: this( "Amaura", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Amaura Constructor waiting for no params
		/// </summary>
		/*
		public Amaura() : this( "Amaura", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}