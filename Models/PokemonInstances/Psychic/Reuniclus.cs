using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Reuniclus PokemonInstance Class
	#region Reuniclus
	public class Reuniclus : PokemonInstance
	{
		#region Reuniclus Constructors
		/// <summary>
		/// Reuniclus Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Reuniclus(string nickname, int level)
		: base(
				ReuniclusSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Reuniclus Constructor only waiting for a Level
		/// </summary>
		public Reuniclus(int level)
		: this( "Reuniclus", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Reuniclus Constructor waiting for no params
		/// </summary>
		/*
		public Reuniclus() : this( "Reuniclus", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}