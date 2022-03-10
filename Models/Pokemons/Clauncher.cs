using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Clauncher Species to store common natural stats of all Claunchers
	#region SpeciesClauncher
	public class SpeciesClauncher : PokemonSpecies
	{
#nullable enable
		private static SpeciesClauncher? _instance = null;
#nullable restore
        public static SpeciesClauncher Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesClauncher();
                }
                return _instance;
            }
        }

		#region SpeciesClauncher Constructor
		public SpeciesClauncher() : base(
			"Clauncher",
			0.5,
			8.3,
			50, // HPs
			53, 62, // Attack & Defense
			58, 63, // Special Attack & Defense
			44		
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
				"Vice-Grip",
				"Swords-Dance",
				"Cut",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Bubble-Beam",
				"Toxic",
				"Double-Team",
				"Waterfall",
				"Bubble",
				"Splash",
				"Crabhammer",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Flail",
				"Protect",
				"Sludge-Bomb",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Facade",
				"Helping-Hand",
				"Secret-Power",
				"Dive",
				"Muddy-Water",
				"Bounce",
				"Water-Sport",
				"Water-Pulse",
				"U-Turn",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Flash-Cannon",
				"Aqua-Jet",
				"Venoshock",
				"Smack-Down",
				"Sludge-Wave",
				"Entrainment",
				"Round",
				"Scald",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Clauncher PokemonInstance Class
	#region Clauncher
	public class ClauncherInstance : PokemonInstance
	{
		#region Clauncher Constructors
		/// <summary>
		/// Clauncher Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ClauncherInstance(string nickname, int level)
		: base(
				692,
				SpeciesClauncher.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Clauncher Builder only waiting for a Level
		/// </summary>
		public ClauncherInstance(int level)
		: base(
				692,
				SpeciesClauncher.Instance, // PokemonInstance Species
				"Clauncher", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Clauncher Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Clauncher() : base(
			692,
			SpeciesClauncher.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}