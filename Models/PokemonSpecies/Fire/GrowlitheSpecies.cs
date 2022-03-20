using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Growlithe Species to store common natural stats of all Growlithes
	#region GrowlitheSpecies
	public class GrowlitheSpecies : PokemonSpecies
	{
#nullable enable
		private static GrowlitheSpecies? _instance = null;
#nullable restore
        public static GrowlitheSpecies Instance => _instance ?? (_instance = new GrowlitheSpecies());

		#region GrowlitheSpecies Constructor
		public GrowlitheSpecies() : base(
			58,
			"Growlithe",
			Fire.Instance,
			0.7,
			19.0,
			new PokemonStats(
				55, // HPs
				70, 45, // Attack & Defense
				70, 50, // Spacial Attack & Defense
				60 // Speed
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
				"Double-Kick",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Thrash",
				"Double-Edge",
				"Leer",
				"Bite",
				"Roar",
				"Ember",
				"Flamethrower",
				"Strength",
				"Dragon-Rage",
				"Fire-Spin",
				"Dig",
				"Toxic",
				"Agility",
				"Rage",
				"Mimic",
				"Double-Team",
				"Reflect",
				"Bide",
				"Fire-Blast",
				"Swift",
				"Skull-Bash",
				"Rest",
				"Substitute",
				"Thief",
				"Flame-Wheel",
				"Snore",
				"Curse",
				"Reversal",
				"Protect",
				"Mud-Slap",
				"Outrage",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Dragon-Breath",
				"Iron-Tail",
				"Morning-Sun",
				"Hidden-Power",
				"Sunny-Day",
				"Crunch",
				"Rock-Smash",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Helping-Hand",
				"Secret-Power",
				"Overheat",
				"Odor-Sleuth",
				"Aerial-Ace",
				"Howl",
				"Covet",
				"Natural-Gift",
				"Close-Combat",
				"Flare-Blitz",
				"Fire-Fang",
				"Captivate",
				"Flame-Burst",
				"Flame-Charge",
				"Round",
				"Incinerate",
				"Retaliate",
				"Wild-Charge",
				"Snarl",
				"Confide",
				"Burn-Up"
			};
		}
		#endregion
	}
	#endregion
}