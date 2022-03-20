using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Vulpix Species to store common natural stats of all Vulpixs
	#region VulpixSpecies
	public class VulpixSpecies : PokemonSpecies
	{
#nullable enable
		private static VulpixSpecies? _instance = null;
#nullable restore
        public static VulpixSpecies Instance => _instance ?? (_instance = new VulpixSpecies());

		#region VulpixSpecies Constructor
		public VulpixSpecies() : base(
			37,
			"Vulpix",
			Fire.Instance,
			0.6,
			9.9,
			new PokemonStats(
				38, // HPs
				41, 40, // Attack & Defense
				50, 65, // Spacial Attack & Defense
				65 // Speed
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
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Tail-Whip",
				"Roar",
				"Disable",
				"Ember",
				"Flamethrower",
				"Fire-Spin",
				"Dig",
				"Toxic",
				"Hypnosis",
				"Quick-Attack",
				"Rage",
				"Mimic",
				"Double-Team",
				"Confuse-Ray",
				"Reflect",
				"Bide",
				"Fire-Blast",
				"Swift",
				"Skull-Bash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Flail",
				"Spite",
				"Protect",
				"Feint-Attack",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Pain-Split",
				"Iron-Tail",
				"Hidden-Power",
				"Sunny-Day",
				"Psych-Up",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Role-Play",
				"Imprison",
				"Grudge",
				"Secret-Power",
				"Overheat",
				"Extrasensory",
				"Howl",
				"Covet",
				"Natural-Gift",
				"Payback",
				"Power-Swap",
				"Flare-Blitz",
				"Dark-Pulse",
				"Energy-Ball",
				"Zen-Headbutt",
				"Captivate",
				"Ominous-Wind",
				"Flame-Burst",
				"Flame-Charge",
				"Foul-Play",
				"Round",
				"Hex",
				"Incinerate",
				"Inferno",
				"Tail-Slap",
				"Confide",
				"Baby-Doll-Eyes"
			};
		}
		#endregion
	}
	#endregion
}