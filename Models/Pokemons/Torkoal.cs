using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Torkoal Specie to store common natural stats of every {'abilities': ['white-smoke', 'drought', 'shell-armor'], 'base_experience': 165, 'height': 5, 'id': 324, 'moves': ['headbutt', 'body-slam', 'double-edge', 'ember', 'flamethrower', 'hyper-beam', 'strength', 'solar-beam', 'fire-spin', 'earthquake', 'fissure', 'toxic', 'mimic', 'double-team', 'smokescreen', 'withdraw', 'self-destruct', 'smog', 'fire-blast', 'skull-bash', 'amnesia', 'explosion', 'rest', 'rock-slide', 'substitute', 'flame-wheel', 'snore', 'curse', 'flail', 'protect', 'sludge-bomb', 'mud-slap', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'rapid-spin', 'iron-tail', 'hidden-power', 'sunny-day', 'rock-smash', 'heat-wave', 'will-o-wisp', 'facade', 'nature-power', 'superpower', 'yawn', 'eruption', 'secret-power', 'overheat', 'rock-tomb', 'iron-defense', 'gyro-ball', 'natural-gift', 'earth-power', 'giga-impact', 'lava-plume', 'stone-edge', 'captivate', 'stealth-rock', 'flame-burst', 'flame-charge', 'after-you', 'round', 'clear-smog', 'shell-smash', 'incinerate', 'inferno', 'bulldoze', 'confide'], 'name': 'torkoal', 'stats': {'hp': 70, 'attack': 85, 'defense': 140, 'special-attack': 85, 'special-defense': 70, 'speed': 20}, 'types': ['fire'], 'weight': 804, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 90, 'color': 'brown', 'shape': 'quadruped', 'habitat': 'mountain', 'generation': 'generation-iii', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'コータス', 'roomaji': 'Cotoise', 'ko': '코터스', 'zh-Hant': '煤炭龜', 'fr': 'Chartor', 'de': 'Qurtel', 'es': 'Torkoal', 'it': 'Torkoal', 'en': 'Torkoal', 'ja': 'コータス', 'zh-Hans': '煤炭龟'}, 'genera': {'ja-Hrkt': 'せきたんポケモン', 'ko': '석탄포켓몬', 'zh-Hant': '煤炭寶可夢', 'fr': 'Pokémon Charbon', 'de': 'Kohle', 'es': 'Pokémon Carbón', 'it': 'Pokémon Carbone', 'en': 'Coal Pokémon', 'ja': 'せきたんポケモン', 'zh-Hans': '煤炭宝可梦'}}
	public class SpecieTorkoal : PokemonSpecie
	{
#nullable enable
		private static SpecieTorkoal? _instance = null;
#nullable restore
        public static SpecieTorkoal Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTorkoal();
                }
                return _instance;
            }
        }

		public SpecieTorkoal() : base(
			"Torkoal",
			70, // HPs
			85, 140, // Attack & Defense
			85, 70, // Special Attack & Defense
			20			
		) {}
	}


	//Torkoal Pokemon Class
	public class Torkoal : Pokemon
	{

		public Torkoal(string nickname, int level) : base(
			324,
			SpecieTorkoal.Instance, // Pokemon Specie
			nickname, level,
			Fire.Instance			
		) {}

		public Torkoal() : base(
			324,
			SpecieTorkoal.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
	}
}