using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Ducklett Species to store common natural stats of all Duckletts
	#region SpeciesDucklett
	public class SpeciesDucklett : PokemonSpecies
	{
#nullable enable
		private static SpeciesDucklett? _instance = null;
#nullable restore
        public static SpeciesDucklett Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesDucklett();
                }
                return _instance;
            }
        }

		#region SpeciesDucklett Constructor
		public SpeciesDucklett() : base(
			"Ducklett",
			0.5,
			5.5,
			62, // HPs
			44, 50, // Attack & Defense
			44, 50, // Special Attack & Defense
			55		
		)
		{
			InitMovesList();
		}
		#endregion

		#region Methods
		private void InitMovesList()
		{
			_moveList = new List<string>()
			{
				"Gust",
				"Wing-Attack",
				"Fly",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Bubble-Beam",
				"Toxic",
				"Double-Team",
				"Mirror-Move",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Icy-Wind",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Uproar",
				"Hail",
				"Facade",
				"Endeavor",
				"Secret-Power",
				"Dive",
				"Feather-Dance",
				"Mud-Sport",
				"Air-Cutter",
				"Aerial-Ace",
				"Water-Sport",
				"Water-Pulse",
				"Roost",
				"Brine",
				"Pluck",
				"Tailwind",
				"Lucky-Chant",
				"Me-First",
				"Aqua-Ring",
				"Air-Slash",
				"Brave-Bird",
				"Defog",
				"Aqua-Jet",
				"Round",
				"Scald",
				"Hurricane",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Ducklett PokemonInstance Class
	#region Ducklett
	public class DucklettInstance : PokemonInstance
	{
		#region Ducklett Constructors
		/// <summary>
		/// Ducklett Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public DucklettInstance(string nickname, int level)
		: base(
				580,
				SpeciesDucklett.Instance, // Pokemon Species
				nickname, level,
				Water.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ducklett Builder only waiting for a Level
		/// </summary>
		public DucklettInstance(int level)
		: base(
				580,
				SpeciesDucklett.Instance, // PokemonInstance Species
				"Ducklett", level,
				Water.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ducklett Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Ducklett() : base(
			580,
			SpeciesDucklett.Instance, // PokemonInstance Species
			Water.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}