using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Groudon Specie to store common natural stats of every {'abilities': ['drought'], 'base_experience': 302, 'height': 35, 'id': 383, 'moves': ['mega-punch', 'fire-punch', 'thunder-punch', 'swords-dance', 'cut', 'mega-kick', 'headbutt', 'body-slam', 'double-edge', 'roar', 'flamethrower', 'hyper-beam', 'counter', 'seismic-toss', 'strength', 'solar-beam', 'thunderbolt', 'thunder-wave', 'thunder', 'earthquake', 'fissure', 'dig', 'toxic', 'mimic', 'double-team', 'defense-curl', 'fire-blast', 'swift', 'rest', 'rock-slide', 'slash', 'substitute', 'snore', 'protect', 'scary-face', 'mud-slap', 'sandstorm', 'endure', 'rollout', 'swagger', 'fury-cutter', 'sleep-talk', 'return', 'frustration', 'safeguard', 'dynamic-punch', 'iron-tail', 'hidden-power', 'sunny-day', 'psych-up', 'ancient-power', 'rock-smash', 'uproar', 'facade', 'brick-break', 'eruption', 'secret-power', 'overheat', 'rock-tomb', 'aerial-ace', 'block', 'dragon-claw', 'bulk-up', 'mud-shot', 'shock-wave', 'hammer-arm', 'natural-gift', 'fling', 'rock-polish', 'dragon-pulse', 'focus-blast', 'earth-power', 'giga-impact', 'shadow-claw', 'rock-climb', 'lava-plume', 'iron-head', 'stone-edge', 'stealth-rock', 'hone-claws', 'smack-down', 'round', 'incinerate', 'bulldoze', 'dragon-tail', 'confide', 'power-up-punch', 'precipice-blades', 'brutal-swing'], 'name': 'groudon', 'stats': {'hp': 100, 'attack': 150, 'defense': 140, 'special-attack': 100, 'special-defense': 90, 'speed': 90}, 'types': ['ground'], 'weight': 9500, 'is_baby': False, 'is_legendary': True, 'is_mythical': False, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 3, 'color': 'red', 'shape': 'upright', 'habitat': 'rough-terrain', 'generation': 'generation-iii', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'グラードン', 'roomaji': 'Groudon', 'ko': '그란돈', 'zh-Hant': '固拉多', 'fr': 'Groudon', 'de': 'Groudon', 'es': 'Groudon', 'it': 'Groudon', 'en': 'Groudon', 'ja': 'グラードン', 'zh-Hans': '固拉多'}, 'genera': {'ja-Hrkt': 'たいりくポケモン', 'ko': '대륙포켓몬', 'zh-Hant': '大陸寶可夢', 'fr': 'Pokémon Continent', 'de': 'Kontinent', 'es': 'Pokémon Continente', 'it': 'Pokémon Continente', 'en': 'Continent Pokémon', 'ja': 'たいりくポケモン', 'zh-Hans': '大陆宝可梦'}}
	public class SpecieGroudon : PokemonSpecie
	{
#nullable enable
		private static SpecieGroudon? _instance = null;
#nullable restore
        public static SpecieGroudon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGroudon();
                }
                return _instance;
            }
        }

		public SpecieGroudon() : base(
			"Groudon",
			100, // HPs
			150, 140, // Attack & Defense
			100, 90, // Special Attack & Defense
			90			
		) {}
	}


	//Groudon Pokemon Class
	public class Groudon : Pokemon
	{

		public Groudon(string nickname, int level) : base(
			383,
			SpecieGroudon.Instance, // Pokemon Specie
			nickname, level,
			Ground.Instance			
		) {}

		public Groudon() : base(
			383,
			SpecieGroudon.Instance, // Pokemon Specie
			Ground.Instance			
		) {}
	}
}