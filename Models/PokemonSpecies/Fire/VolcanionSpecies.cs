using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Volcanion Species to store common natural stats of all Volcanions
	#region VolcanionSpecies
	public class VolcanionSpecies : PokemonSpecies
	{
#nullable enable
		private static VolcanionSpecies? _instance = null;
#nullable restore
        public static VolcanionSpecies Instance => _instance ?? (_instance = new VolcanionSpecies());

		#region VolcanionSpecies Constructor
		public VolcanionSpecies() : base(
			721,
			"Volcanion",
			Fire.Instance, Water.Instance,
			1.7,
			195.0,
			new PokemonStats(
				80, // HPs
				110, 120, // Attack & Defense
				130, 90, // Spacial Attack & Defense
				70 // Speed
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
				"Cut",
				"Stomp",
				"Body-Slam",
				"Take-Down",
				"Roar",
				"Flamethrower",
				"Mist",
				"Hydro-Pump",
				"Hyper-Beam",
				"Strength",
				"Solar-Beam",
				"Earthquake",
				"Toxic",
				"Double-Team",
				"Haze",
				"Fire-Blast",
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Sludge-Bomb",
				"Sandstorm",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Superpower",
				"Brick-Break",
				"Secret-Power",
				"Weather-Ball",
				"Overheat",
				"Water-Pulse",
				"Gyro-Ball",
				"Fling",
				"Flare-Blitz",
				"Focus-Blast",
				"Earth-Power",
				"Giga-Impact",
				"Flash-Cannon",
				"Stone-Edge",
				"Smack-Down",
				"Sludge-Wave",
				"Flame-Charge",
				"Round",
				"Scald",
				"Incinerate",
				"Bulldoze",
				"Confide",
				"Steam-Eruption"
			};
		}
		#endregion
	}
	#endregion
}