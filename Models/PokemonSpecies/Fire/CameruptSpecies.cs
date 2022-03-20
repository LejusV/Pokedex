using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Camerupt Species to store common natural stats of all Camerupts
	#region CameruptSpecies
	public class CameruptSpecies : PokemonSpecies
	{
#nullable enable
		private static CameruptSpecies? _instance = null;
#nullable restore
        public static CameruptSpecies Instance => _instance ?? (_instance = new CameruptSpecies());

		#region CameruptSpecies Constructor
		public CameruptSpecies() : base(
			323,
			"Camerupt",
			Fire.Instance, Ground.Instance,
			1.9,
			220.0,
			new PokemonStats(
				70, // HPs
				100, 70, // Attack & Defense
				105, 75, // Spacial Attack & Defense
				40 // Speed
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
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Growl",
				"Roar",
				"Ember",
				"Flamethrower",
				"Hyper-Beam",
				"Strength",
				"Solar-Beam",
				"Earthquake",
				"Fissure",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Focus-Energy",
				"Self-Destruct",
				"Fire-Blast",
				"Amnesia",
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Magnitude",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Nature-Power",
				"Yawn",
				"Eruption",
				"Secret-Power",
				"Overheat",
				"Rock-Tomb",
				"Natural-Gift",
				"Rock-Polish",
				"Earth-Power",
				"Giga-Impact",
				"Flash-Cannon",
				"Lava-Plume",
				"Iron-Head",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Flame-Burst",
				"Flame-Charge",
				"After-You",
				"Round",
				"Echoed-Voice",
				"Incinerate",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}