using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Keldeo-Ordinary Species to store common natural stats of all Keldeo-Ordinarys
	#region Keldeo-OrdinarySpecies
	public class KeldeoOrdinarySpecies : PokemonSpecies
	{
#nullable enable
		private static KeldeoOrdinarySpecies? _instance = null;
#nullable restore
        public static KeldeoOrdinarySpecies Instance => _instance ?? (_instance = new KeldeoOrdinarySpecies());

		#region Keldeo-OrdinarySpecies Constructor
		public KeldeoOrdinarySpecies() : base(
			647,
			"Keldeo-Ordinary",
			Water.Instance, Fighting.Instance,
			1.4,
			48.5,
			new PokemonStats(
				91, // HPs
				72, 90, // Attack & Defense
				129, 90, // Spacial Attack & Defense
				108 // Speed
			)			
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
				"Swords-Dance",
				"Cut",
				"Double-Kick",
				"Take-Down",
				"Leer",
				"Roar",
				"Hydro-Pump",
				"Surf",
				"Bubble-Beam",
				"Hyper-Beam",
				"Strength",
				"Toxic",
				"Double-Team",
				"Reflect",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Icy-Wind",
				"False-Swipe",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Rain-Dance",
				"Psych-Up",
				"Rock-Smash",
				"Hail",
				"Facade",
				"Taunt",
				"Helping-Hand",
				"Superpower",
				"Endeavor",
				"Secret-Power",
				"Aerial-Ace",
				"Bounce",
				"Covet",
				"Calm-Mind",
				"Water-Pulse",
				"Close-Combat",
				"Last-Resort",
				"Poison-Jab",
				"Aqua-Tail",
				"X-Scissor",
				"Focus-Blast",
				"Giga-Impact",
				"Stone-Edge",
				"Aqua-Jet",
				"Round",
				"Quick-Guard",
				"Scald",
				"Retaliate",
				"Work-Up",
				"Sacred-Sword",
				"Secret-Sword",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}