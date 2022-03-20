using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Nidoran-M PokemonInstance Class
	#region Nidoran-M
	public class NidoranM : PokemonInstance
	{
		#region Nidoran-M Constructors
		/// <summary>
		/// Nidoran-M Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public NidoranM(string nickname, int level)
		: base(
				NidoranMSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nidoran-M Constructor only waiting for a Level
		/// </summary>
		public NidoranM(int level)
		: this( "Nidoran-M", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nidoran-M Constructor waiting for no params
		/// </summary>
		/*
		public NidoranM() : this( "Nidoran-M", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}