using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Marill PokemonInstance Class
	#region Marill
	public class Marill : PokemonInstance
	{
		#region Marill Constructors
		/// <summary>
		/// Marill Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Marill(string nickname, int level)
		: base(
				MarillSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Marill Constructor only waiting for a Level
		/// </summary>
		public Marill(int level)
		: this( "Marill", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Marill Constructor waiting for no params
		/// </summary>
		/*
		public Marill() : this( "Marill", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}